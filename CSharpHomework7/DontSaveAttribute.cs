﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHomework7
{
    [AttributeUsage(AttributeTargets.Property)]
    public class DontSaveAttribute : Attribute
    {
        public DontSaveAttribute() { }
    }
}
