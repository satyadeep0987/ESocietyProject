using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace IDatabase
{
    public interface IAdditionalFacilityDetails
    {
        IEnumerable<AdditionalFacilityDetails> GetAdditionalFacilityDetails();
        AdditionalFacilityDetails GetByIdAdditionalFacilityDetails(int id);
        bool PostAdditionalFacilityDetails(AdditionalFacilityDetails d);
        string PutAdditionalFacilityDetails(AdditionalFacilityDetails d, int id);
    }
}
