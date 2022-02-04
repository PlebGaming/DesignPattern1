using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    public interface ITag
    {
        public string htmlTag { get; set; }
        public string GetTag();
    }
}
