using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    public class ItalicDecorator : TagDecorator
    {
        public ItalicDecorator(ITag tag) : base(tag)
        {
            htmlTag = "Italic ";
        }
    }
}
