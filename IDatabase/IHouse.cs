using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace IDatabase
{
    public interface IHouse
    {
        IEnumerable<House> GetHouse();

        //perticular ek row ke uthane ke liye
        House GetByIdHouse(string id);

        //data insert karne ke liye
        bool PostHouse(House h);

        //data update krne ke liye
        string PutHouse(string id, House h);
    }
}
