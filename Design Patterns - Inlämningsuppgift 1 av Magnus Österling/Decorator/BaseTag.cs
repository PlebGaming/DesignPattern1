using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    public class BaseTag : ITag
    {
        public string htmlTag { get; set; }
        public BaseTag(string inputTag)
        {
            htmlTag = inputTag;
        }
        public string GetTag()
        {
            return htmlTag;
        }
    }
}
