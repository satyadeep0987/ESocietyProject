using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace IDatabase
{
    public interface IFunctionCategory
    {
        //sare elements uthane ke liye hai

        IEnumerable<FunctionCategory> GetIFunctionCategory();

        //perticular ek row ke uthane ke liye
        FunctionCategory GetByIdFunctionCategory(int id);

        //data insert karne ke liye
        bool PostFunctionCategory(FunctionCategory f);

        //data update krne ke liye
        string PutFunctionCategory(int id, FunctionCategory f);
    }
}
