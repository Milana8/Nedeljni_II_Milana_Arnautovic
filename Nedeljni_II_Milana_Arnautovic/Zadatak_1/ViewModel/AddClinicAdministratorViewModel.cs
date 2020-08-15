using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Zadatak_1.Command;
using Zadatak_1.Model;
using Zadatak_1.View;

namespace Zadatak_1.ViewModel
{
    class AddClinicAdministratorViewModel :ViewModelBase
   
    {

        AddClinicAdministratorView view;
        Service service = new Service();
        Validation validation = new Validation();

        public AddClinicAdministratorViewModel(AddClinicAdministratorView view)
        {
            this.view = view;
            administrator = new vwAdministrator();
            AdminList = service.GetAllAdministratorView().ToList();

        }

        #region Properties
        private vwAdministrator administrator;
        public vwAdministrator Administrator
        {
            get
            {
                return administrator;
            }
            set
            {
                administrator = value;
                OnPropertyChanged("Administrator");
            }
        }
        #region Properties
        private List<vwAdministrator> adminList;
        public List<vwAdministrator> AdminList
        {
            get { return adminList; }
            set
            {
                adminList = value;
                OnPropertyChanged("AdminList");
            }
        }

        

        /// <summary>
        /// Checks if its possible to execute the add and edit admin commands
        /// </summary>
        private bool isUpdateAdmin;
        public bool IsUpdateAdmin
        {
            get
            {
                return isUpdateAdmin;
            }
            set
            {
                isUpdateAdmin = value;
            }
        }
        #endregion

        #endregion

        #region Commands
        private ICommand save;
        public ICommand Save
        {
            get
            {
                if (save == null)
                {
                    save = new RelayCommand(param => SaveExecute(), param => CanSaveExecute());
                }
                return save;
            }
        }

        private ICommand close;
        public ICommand Close
        {
            get
            {
                if (close == null)
                {
                    close = new RelayCommand(param => CloseExecute(), param => CanCloseExecute());
                }
                return close;
            }
        }

        #endregion

        #region Functions

        private void SaveExecute()
        {
            var result = MessageBox.Show("Are you sure you want to create this admin?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    service.AddAdministrator(Administrator);
                    IsUpdateAdmin = true;
                    service.GetAllAdministratorView().ToList();
                    MessageBox.Show("You successfully created admin!", "Notification");
                    view.Close();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Exception" + ex.Message.ToString());
                }
            }
            else
            {
                return;
            }
        }


        private bool CanSaveExecute()
        { 

             if (Validation.IDCard(Administrator.IdCard) && Validation.Password(Administrator.Pasword))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

    private void CloseExecute()
        {
            view.Close();
        }

        private bool CanCloseExecute()
        {
            return true;
        }
        #endregion
    }
}