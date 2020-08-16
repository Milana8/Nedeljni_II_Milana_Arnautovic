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
        /// <summary>
        /// Get All Users from db
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Get all admin from db
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Method to add an administrator
        /// </summary>
        /// <param name="administrator"></param>
        /// <returns></returns>
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
                        Pasword = SecurePasswordHasher.Hash(administrator.Pasword),
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
        /// <summary>
        /// Checks if there is user with that username
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public bool IsUser(string username)
        {
            try
            {
                using (Nedeljni_IIEntities context = new Nedeljni_IIEntities())
                {
                    vwAdministrator admin = (from e in context.vwAdministrators where e.Username == username select e).First();

                    if (admin == null)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception" + ex.Message.ToString());
                return false;
            }
        }
        /// <summary>
        /// Find the administrator by username
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public vwAdministrator FindAdmin(string username)
        {
            try
            {
                using (Nedeljni_IIEntities context = new Nedeljni_IIEntities())
                {
                    vwAdministrator admin = (from e in context.vwAdministrators where e.Username == username select e).First();
                    return admin;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception" + ex.Message.ToString());
                return null;
            }
        }

        public List<tblClinic> GetAllClinics()
        {
            try
            {
                using (Nedeljni_IIEntities context = new Nedeljni_IIEntities())
                {
                    List<tblClinic> list = new List<tblClinic>();
                    list = (from x in context.tblClinics select x).ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception" + ex.Message.ToString());
                return null;
            }
        }
        /// <summary>
        /// Method to add an clinic
        /// </summary>
        /// <param name="clinicToAdd"></param>
        public void AddClinic(tblClinic clinicToAdd)
        {
            try
            {
                using (Nedeljni_IIEntities context = new Nedeljni_IIEntities())
                {
                    tblClinic clinic = new tblClinic
                    {
                        ClinicName = clinicToAdd.ClinicName,
                        DateConstruction = clinicToAdd.DateConstruction,
                        ClinicOwner = clinicToAdd.ClinicOwner,
                        Adress = clinicToAdd.Adress,
                        FloorNumber = clinicToAdd.FloorNumber,
                        NumberRoomsPerFloor = clinicToAdd.NumberRoomsPerFloor,
                        Balcony = clinicToAdd.Balcony,
                        Garden=clinicToAdd.Garden,
                        AmbulancesParking= clinicToAdd.AmbulancesParking,
                        InvalidParking = clinicToAdd.InvalidParking,

                                                                                                                                  };
                    context.tblClinics.Add(clinic);
                    context.SaveChanges();
                    clinicToAdd.ClinicID = clinic.ClinicID;
                    
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception" + ex.Message.ToString());
            }
        }
        /// <summary>
        /// Metod to edit an clinic
        /// </summary>
        /// <param name="clinic"></param>
        /// <returns></returns>
        public tblClinic EditClinic(tblClinic clinic)
        {
            try
            {
                using (Nedeljni_IIEntities context = new Nedeljni_IIEntities())
                {
                    tblClinic clinicToEdit = context.tblClinics.Where(x => x.ClinicID ==clinic.ClinicID).FirstOrDefault();
                    clinicToEdit.ClinicOwner = clinic.ClinicOwner;
                    clinicToEdit.AmbulancesParking = clinic.AmbulancesParking;
                    clinicToEdit.InvalidParking = clinic.InvalidParking;
                    context.SaveChanges();
                    
                    return clinic;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception" + ex.Message.ToString());
                return null;
            }
        }
    }
}
   
