using NeuSoft.Client.Contract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace NeuSoft.Client.WinForm
{
    internal static class PluginDriver
    {
        const string COMPANY = "NeuSoft";
        const string PRODUCT = "IME.Plugin";
        static readonly string _root;
        static readonly Type _attrType;
        static readonly Type _interfaceType;
        static object _lock;
        static PluginAttributeComparer _comparer;
        static Dictionary<int, SortedDictionary<PluginAttribute, IPlugin>> _visuals;
        static Dictionary<int, SortedDictionary<PluginAttribute, IPlugin>> _services;
        static SortedDictionary<PluginAttribute, IPlugin> _plugins;

        static PluginDriver()
        {
            _root = $"{AppDomain.CurrentDomain.BaseDirectory}/plugins";
            _attrType = typeof(PluginAttribute);
            _interfaceType = typeof(IPlugin);
            _lock = new object();
            _comparer = new PluginAttributeComparer();
            _visuals = new Dictionary<int, SortedDictionary<PluginAttribute, IPlugin>>();
            _services = new Dictionary<int, SortedDictionary<PluginAttribute, IPlugin>>();
            _plugins = new SortedDictionary<PluginAttribute, IPlugin>(_comparer);
        }

        static Assembly Filter(this FileInfo dll)
        {
            var asm = Assembly.ReflectionOnlyLoadFrom(dll.FullName);
            var attributes = CustomAttributeData.GetCustomAttributes(asm);
            var company = attributes.FirstOrDefault(attribute => attribute.Constructor.ReflectedType == typeof(AssemblyCompanyAttribute));
            if (company == null || company.ConstructorArguments[0].Value == null || company.ConstructorArguments[0].Value as string != COMPANY)
            {
                return null;
            }
            var product = attributes.FirstOrDefault(attribute => attribute.Constructor.ReflectedType == typeof(AssemblyProductAttribute));
            if (product == null || product.ConstructorArguments[0].Value == null || !(product.ConstructorArguments[0].Value as string).StartsWith(PRODUCT))
            {
                return null;
            }
            return Assembly.LoadFrom(dll.FullName);
        }

        static bool IsImplementOf(this Type type, Type interfaceType)
        {
            return type.GetInterfaces().Contains(interfaceType);
        }

        internal static void Initialize(Action<PluginError> onError)
        {
            if (_lock == null)
            {
                onError?.Invoke(new PluginError { Message = "已经完成了初始化。" });
                return;
            }
            lock (_lock)
            {
                var entryType = typeof(IPlugin);
                foreach (var file in (Directory.Exists(_root) ? new DirectoryInfo(_root) :
                    Directory.CreateDirectory(_root)).GetFiles("*.dll"))
                {
                    Assembly asm;
                    try
                    {
                        asm = file.Filter();
                        if (asm == null)
                        {
                            onError?.Invoke(new PluginError { FileName = file.FullName, Message = "程序集不符合契约规则。" });
                            continue;
                        }
                    }
                    catch (Exception ex)
                    {
                        onError?.Invoke(new PluginError { FileName = file.FullName, Exception = ex, Message = ex.Message });
                        continue;
                    }
                    foreach (var type in asm.GetExportedTypes())
                    {
                        if (type.IsInterface || type.IsAbstract || !type.IsImplementOf(entryType))
                        {
                            continue;
                        }
                        if (type.GetConstructor(Type.EmptyTypes) == null)
                        {
                            onError?.Invoke(new PluginError { Type = type, Message = "插件类型必须包含无参数构造。" });
                            continue;
                        }
                        var attr = type.GetCustomAttributes(_attrType, false).FirstOrDefault() as PluginAttribute;
                        if (attr == null)
                        {
                            onError?.Invoke(new PluginError { Type = type, Message = "插件类型未定义必要特性。" });
                            continue;
                        }
                        if (_plugins.ContainsKey(attr))
                        {
                            onError?.Invoke(new PluginError { Attribute = attr, Type = type, Message = "插件特性Id已存在。" });
                            continue;
                        }
                        var plugin = Activator.CreateInstance(type) as IPlugin;
                        if (attr.AsVisual)
                        {
                            if (Control.FromHandle(plugin.Handle) == null)
                            {
                                onError?.Invoke(new PluginError { Attribute = attr, Type = type, Message = "插件特性AsVisual为true，但插件类型未找到可用控件。" });
                                continue;
                            }
                            SortedDictionary<PluginAttribute, IPlugin> dict;
                            if (!_visuals.TryGetValue(attr.GroupId, out dict))
                            {
                                _visuals[attr.GroupId] = dict = new SortedDictionary<PluginAttribute, IPlugin>(_comparer);
                            }
                            dict.Add(attr, plugin);
                        }
                        else
                        {
                            SortedDictionary<PluginAttribute, IPlugin> dict;
                            if (!_services.TryGetValue(attr.GroupId, out dict))
                            {
                                _services[attr.GroupId] = dict = new SortedDictionary<PluginAttribute, IPlugin>(_comparer);
                            }
                            dict.Add(attr, plugin);
                        }
                        _plugins.Add(attr, plugin);
                    }
                }
            }
            _lock = null;
        }

        internal static IEnumerable<KeyValuePair<PluginAttribute, IPlugin>> GetVisuals()
        {
            return _lock == null ? _plugins.Where(pair => pair.Key.AsVisual) : new KeyValuePair<PluginAttribute, IPlugin>[0];
        }
    }
}
