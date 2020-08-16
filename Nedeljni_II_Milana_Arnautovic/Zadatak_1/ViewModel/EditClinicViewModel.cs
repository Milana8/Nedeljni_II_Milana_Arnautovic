using System;
using System.Collections.Generic;
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
    class EditClinicViewModel : ViewModelBase
    {
        EditClinicView editClinicView;
        Service service = new Service();
        Validation validation = new Validation();

        public tblClinic ClinicBeforeEdit { get; set; }

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

        public EditClinicViewModel(EditClinicView editClinicView, tblClinic clinic)
        {
            this.editClinicView = editClinicView;
            Clinic = clinic;
            ClinicBeforeEdit = new tblClinic
            {
                ClinicOwner = clinic.ClinicOwner,
                AmbulancesParking = clinic.AmbulancesParking,
                InvalidParking = clinic.InvalidParking,

            };
        }
        /// <summary>
        /// This method invokes a method for editing clinic.
        /// </summary>
        public void SaveExecute()
        {
            try
            {
                service.EditClinic(Clinic);
                editClinicView.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
        public bool CanSaveExecute()
        {

            if (Clinic.AmbulancesParking > ClinicBeforeEdit.AmbulancesParking && Clinic.InvalidParking > ClinicBeforeEdit.InvalidParking)
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
            editClinicView.Close();
        }

        private bool CanCloseExecute()
        {
            return true;
        }
    }
}
