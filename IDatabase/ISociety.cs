using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
namespace IDatabase
{
    public interface ISociety
    {
        IEnumerable<Society> GetAllSociety();

        Society GetByIdSociety(string id);
        bool PostSociety(Society s);
        string PutSociety(string id, Society s);
    }
}
