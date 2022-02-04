using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    public interface IDataRepository
    {
        string Load(string text);
        void Save(string text);
    }
}
