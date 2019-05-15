using System.Collections.Generic;

namespace NeuSoft.Client.Contract
{
    public sealed class PluginAttributeComparer : IEqualityComparer<PluginAttribute>, IComparer<PluginAttribute>
    {
        public bool Equals(PluginAttribute x, PluginAttribute y)
        {
            return x.Id == y.Id;
        }

        public int GetHashCode(PluginAttribute obj)
        {
            return obj.Id.GetHashCode();
        }

        public int Compare(PluginAttribute x, PluginAttribute y)
        {
            if (x.Id == y.Id)
            {
                return 0;
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.Name == y.Name)
            {
                return -1;
            }
            return string.Compare(x.Name, y.Name);
        }
    }
}
