using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace IDatabase
{
    public interface IOwnerRegistration
    {
        IEnumerable<OwnerRegistration> GetOwner();

        OwnerRegistration GetByIdOwnerRegistration(int id);

        bool PostOwnerRegistration(OwnerRegistration o);

        string PutOwnerRegistration(int id, OwnerRegistration o);
    }
}
