using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHomework7
{
    [AttributeUsage(AttributeTargets.Field)]
    public class CustomNameAttribute(string customName) : Attribute
    {
        public string CustomName { get; private set; } = customName;
    }
}
