using System.Drawing;

namespace NeuSoft.Client.Common.Controls
{
    public class UserView
    {
        public UserView(
            string beltline,
            string unit,
            string center,
            string stage,
            string station,
            string name,
            string code,
            Image icon)
        {
            Beltline = beltline;
            Unit = unit;
            Center = center;
            Stage = stage;
            Station = station;
            Name = name;
            Code = code;
            Icon = icon;
        }

        public string Beltline
        {
            get;
        }

        public string Unit
        {
            get;
        }

        public string Center
        {
            get;
        }

        public string Stage
        {
            get;
        }

        public string Station
        {
            get;
        }

        public string Name
        {
            get;
        }

        public string Code
        {
            get;
        }

        public Image Icon
        {
            get;
        }
    }
}
