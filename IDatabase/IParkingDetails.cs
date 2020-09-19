using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace IDatabase
{
    public interface IParkingDetails
    {
        IEnumerable<ParkingDetails> GetParking();
        ParkingDetails GetByParkingId(int id);
        bool PostParking(ParkingDetails p);
        string PutParking(int id, ParkingDetails p);
    }
}
