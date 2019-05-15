using System;

namespace NeuSoft.Client.Contract
{
    public interface IPlugin
    {
        bool Block(PluginMessage message);

        IntPtr Handle { get; }
    }
}
