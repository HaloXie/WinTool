using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeuSoft.Client.Contract
{
    public class PluginError
    {
        public string FileName
        {
            get;
            set;
        }

        public Exception Exception
        {
            get;
            set;
        }

        public PluginAttribute Attribute
        {
            get;
            set;
        }

        public Type Type
        {
            get;
            set;
        }

        public string Message
        {
            get;
            set;
        }
    }
}
