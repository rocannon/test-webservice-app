using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeUwpApp.Services
{
    public interface IRepository
    {
        string GetData();
        bool SaveData();
    }
}
