using System;

namespace NeuSoft.Client.Contract
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public sealed class PluginAttribute : Attribute
    {
        public PluginAttribute(string id, string name)
        {
            Id = id == null || id.Trim() == string.Empty ? throw new ArgumentNullException("id") : id;
            Name = name == null || name.Trim() == string.Empty ? throw new ArgumentNullException("name") : name;
            AsVisual = false;
            Weight = 0;
            Power = 0;
            GroupId = 0;
        }

        public string Id { get; }

        public string Name { get; }

        /// <summary>
        /// 可视化
        /// </summary>
        public bool AsVisual { get; set; }

        /// <summary>
        /// 排序权重
        /// </summary>
        public int Weight { get; set; }

        /// <summary>
        /// 权柄
        /// </summary>
        public long Power { get; set; }

        /// <summary>
        /// 消息组别
        /// </summary>
        public int GroupId { get; set; }
    }
}
