using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    public abstract class TagDecorator :ITag
    {
        public ITag tag { get; set; }
        public string htmlTag { get; set; }
        public TagDecorator(ITag inputTag)
        {
            tag = inputTag;
        }

        public string GetTag()
        {
            return htmlTag + tag.GetTag();
        }
    }
}
