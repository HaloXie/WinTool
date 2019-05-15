using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeuSoft.Client.InterfaceDTO
{
    public class RtnEntity<T>
    {
        public bool IsSuccess { get; set; }
        public T Data { get; set; }

        public string ErrorMsg { get; set; }
    }
}
