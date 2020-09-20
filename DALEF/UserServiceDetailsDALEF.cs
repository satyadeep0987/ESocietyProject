using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using IDatabase;

namespace DALEF
{
    public class UserServiceDetailsDALEF : IUserServiceDetails
    {
        ESocietyProjectEntities es = new ESocietyProjectEntities();
        public IEnumerable<UserServiceDetails> GetAllUserServiceDetails()
        {
            List<UserServiceDetails> us = new List<UserServiceDetails>();
            var res = es.User_Service_Details.ToList();
            foreach (var r in res)
            {
                UserServiceDetails u = new UserServiceDetails();
                u.User_Id = r.User_Id;
                u.Service_Category_ID = r.Service_Category_ID;
                u.User_Name = r.User_Name;
                u.User_Address = r.User_Address;
                u.User_Contact = r.User_Contact;
                u.User_Availability = r.User_Availavility;
                u.User_Rate = r.User_Rate;

                us.Add(u);
            }
            return us;
        }

        public UserServiceDetails GetByIdUserServiceDetails(int id)
        {
            UserServiceDetails u = new UserServiceDetails();
            var r = es.User_Service_Details.Where(x => x.User_Id == id).SingleOrDefault();
            u.User_Id = r.User_Id;
            u.Service_Category_ID = r.Service_Category_ID;
            u.User_Name = r.User_Name;
            u.User_Address = r.User_Address;
            u.User_Contact = r.User_Contact;
            u.User_Availability = r.User_Availavility;
            u.User_Rate = r.User_Rate;
            return u;

        }

        public bool PostUserServiceDetails(UserServiceDetails r)
        {
            try
            {
                User_Service_Details u = new User_Service_Details();
                u.Service_Category_ID = r.Service_Category_ID;
                u.User_Name = r.User_Name;
                u.User_Address = r.User_Address;
                u.User_Contact = r.User_Contact;
                u.User_Availavility = r.User_Availability;
                u.User_Rate = r.User_Rate;
                var res = es.User_Service_Details.Add(u);
                if(res != null)
                {
                    return true;
                }
                return false;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public string PutUserServiceDetails(int id, UserServiceDetails r)
        {

            try
            {
                User_Service_Details us = new User_Service_Details();
                var u = (from user in es.User_Service_Details
                         where user.User_Id == id
                         select user).SingleOrDefault();
                if(r == null)
                {
                    return "Id Invalid";
                }
                else
                {
                    u.Service_Category_ID = r.Service_Category_ID;
                    u.User_Name = r.User_Name;
                    u.User_Address = r.User_Address;
                    u.User_Contact = r.User_Contact;
                    u.User_Availavility = r.User_Availability;
                    u.User_Rate = r.User_Rate;
                    var res = es.SaveChanges();
                    if(res>0)
                    {
                        return "data Inserted";
                    }
                    return "Error In Inserting Data";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
