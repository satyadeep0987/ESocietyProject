using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;


namespace IDatabase
{
    public interface IUserServiceDetails
    {
        IEnumerable<UserServiceDetails> GetAllUserServiceDetails();

        UserServiceDetails GetByIdUserServiceDetails(int id);
        bool PostUserServiceDetails(UserServiceDetails s);
        string PutUserServiceDetails(int id, UserServiceDetails s);
    }
}
