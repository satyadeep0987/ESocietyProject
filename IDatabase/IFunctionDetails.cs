using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace IDatabase
{
    public interface IFunctionDetails
    {
        IEnumerable<FunctionDetails> GetFunctionDetails();
        FunctionDetails GetFunctionDetails(int id);
        bool PostFunctionDetails(FunctionDetails d);
        string PutFunctionDetails(FunctionDetails d, int id);
    }
}
