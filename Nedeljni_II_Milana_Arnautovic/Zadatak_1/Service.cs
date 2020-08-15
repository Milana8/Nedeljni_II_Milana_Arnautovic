using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadatak_1.Model;

namespace Zadatak_1
{
    class Service
    {
        public List<tblUser> GetAllUsers()
        {
            try
            {
                using (Nedeljni_IIEntities context = new Nedeljni_IIEntities())
                {
                    List<tblUser> list = new List<tblUser>();
                    list = (from x in context.tblUsers select x).ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception" + ex.Message.ToString());
                return null;
            }
        }

        public List<tblAdministrator> GetAllAdministrators()
        {
            try
            {
                using (Nedeljni_IIEntities context = new Nedeljni_IIEntities())
                {
                    List<tblAdministrator> list = new List<tblAdministrator>();
                    list = (from x in context.tblAdministrators select x).ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception" + ex.Message.ToString());
                return null;
            }
        }

        public List<vwAdministrator> GetAllAdministratorView()
        {
            try
            {
                using (Nedeljni_IIEntities context = new Nedeljni_IIEntities())
                {
                    List<vwAdministrator> list = new List<vwAdministrator>();
                    list = (from x in context.vwAdministrators select x).ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception" + ex.Message.ToString());
                return null;
            }
        }

        public bool AddAdministrator(vwAdministrator administrator)
        {
            try
            {
                using (Nedeljni_IIEntities context = new Nedeljni_IIEntities())
                {
                    tblUser user = new tblUser
                    {
                        Gender = administrator.Gender,
                        IdCard = administrator.IdCard,
                        DateOfBirth = administrator.DateOfBirth,
                        Citizenship = administrator.Citizenship,
                        FirstName = administrator.FirstName,
                        Pasword = administrator.Pasword,
                        Surname = administrator.Surname,
                        Username = administrator.Username
                    };
                    context.tblUsers.Add(user);
                    context.SaveChanges();
                    administrator.UserID = user.UserID;
                    tblAdministrator newAdministrator = new tblAdministrator
                    {
                        UserID = user.UserID,
                        
                    };
                    context.tblAdministrators.Add(newAdministrator);
                    context.SaveChanges();
                    administrator.AdministratorID = newAdministrator.AdministratorID;
                    return true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception" + ex.Message.ToString());
                return false;
            }
        }
    }
}
