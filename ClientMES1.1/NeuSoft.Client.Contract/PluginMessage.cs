using System;

namespace NeuSoft.Client.Contract
{
    public class PluginMessage
    {
        public PluginMessage(IntPtr sender, int groupId, int type, object value)
        {
            Sender = sender;
            GroupId = groupId;
            Type = type;
            Value = value;
        }

        public PluginMessage(int groupId, int type, object value) : this(IntPtr.Zero, groupId, type, value)
        {
            Sender = null;
        }

        public PluginMessage(IntPtr sender, int type, object value) : this(sender, 0, type, value)
        {
            GroupId = null;
        }

        public PluginMessage(int type, object value) : this(IntPtr.Zero, 0, type, value)
        {
            Sender = null;
            GroupId = null;
        }

        public IntPtr? Sender
        {
            get;
        }

        public int? GroupId
        {
            get;
        }

        public int Type
        {
            get;
        }

        public object Value
        {
            get;
        }
    }
}
