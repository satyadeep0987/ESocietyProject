using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using IDatabase;


namespace DALEF
{
    public class AvailableSlotsDALEF:IAvailableSlots
    {
        ESocietyProjectEntities es = new ESocietyProjectEntities();
        public IEnumerable<AvailableSlots> GetAvailableSlots()
        {

            try
            {
                var res = es.Available_Slots.ToList();

                List<AvailableSlots> slots = new List<AvailableSlots>();

                foreach (var r in res)
                {
                    AvailableSlots a = new AvailableSlots();

                    a.Slot_ID = r.Slot_ID;

                    slots.Add(a);
                }
                return slots;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
