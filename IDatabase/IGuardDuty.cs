using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace IDatabase
{
    public interface IGuardDuty
    {
        IEnumerable<GuardDuty> GetGuardDuty();
        GuardDuty GetByIdVistor(int id);
        bool PostGuardDuty(GuardDuty g);
        string PutGuardDuty(int id, GuardDuty g);
    }
}
