using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGenerator.Data.Interfaces
{
    internal interface IRepositary
    {
        void Init();
        string GetRandomFirstName();
        string GetRandomLastName();
        string GetRandomMiddleName();
        string GetRandomEmailDomain();
    }
}
