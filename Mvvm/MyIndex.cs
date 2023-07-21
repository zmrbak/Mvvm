using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvvm
{
    internal class MyIndex
    {
        public string this[int index] => (index * index).ToString();
        public string this[string index1, string index2] => index1 +":"+ index2;

        public string this[int index1, int index2] => (index1 + index2).ToString();
    }
}
