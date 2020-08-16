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
    class AddClinicViewModel : ViewModelBase
    {
        AddClinicView addClinicView;
        Service service = new Service();

        #region Constructor

        public AddClinicViewModel(AddClinicView addOpen)
        {
            addClinicView = addOpen;
            Clinic = new tblClinic();
            ClinicList = service.GetAllClinics().ToList();
        }

        public AddClinicViewModel(AddClinicView addOpen, tblClinic editClinic)
        {
            addClinicView = addOpen;
            Clinic = editClinic;
            ClinicList = service.GetAllClinics().ToList();
        }
        #endregion

        #region Properties
        private tblClinic clinic;
        public tblClinic Clinic
        {
            get
            {
                return clinic;
            }
            set
            {
                clinic = value;
                OnPropertyChanged("Clinic");
            }
        }

        private List<tblClinic> clinicList;
        public List<tblClinic> ClinicList
        {
            get
            {
                return clinicList;
            }
            set
            {
                clinicList = value;
                OnPropertyChanged("ClinicList");
            }
        }


        private bool isUpdateClinic;
        public bool IsUpdateClinic
        {
            get
            {
                return isUpdateClinic;
            }
            set
            {
                isUpdateClinic = value;
            }
        }
        #endregion
        #region Commands
        /// <summary>
        /// Command save
        /// </summary>
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
        /// <summary>
        /// Command close
        /// </summary>
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
            var result = MessageBox.Show("Are you sure you want to create this clinic?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    service.AddClinic(Clinic);
                    IsUpdateClinic = true;
                    service.GetAllClinics().ToList();
                    MessageBox.Show("You successfully created clinic!", "Notification");
                    addClinicView.Close();
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
            
            return true;
        }


        private void CloseExecute()
        {
            addClinicView.Close();
        }

        private bool CanCloseExecute()
        {
            return true;
        }
        #endregion
    }
}
  
