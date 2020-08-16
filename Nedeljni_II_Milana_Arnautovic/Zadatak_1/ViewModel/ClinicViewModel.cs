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
    class ClinicViewModel :ViewModelBase
    {
        ClinicView clinicView;
        Service service = new Service();

        public ClinicViewModel(ClinicView clinicView)
        {
            this.clinicView = clinicView;
            ClinicList = service.GetAllClinics();
        }


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


        private ICommand addClinic;
        /// <summary>
        /// Add clinic command
        /// </summary>
        public ICommand AddClinic
        {
            get
            {
                if (addClinic == null)
                {
                    addClinic = new RelayCommand(param => AddClinicExecute(), param => CanAddClinicExecute());
                }
                return addClinic;
            }
        }

        /// <summary>
        /// Add clinic execute
        /// </summary>
        private void AddClinicExecute()
        {
            try
            {
                AddClinicView addClinicView = new AddClinicView();
                addClinicView.ShowDialog();
                if ((addClinicView.DataContext as AddClinicViewModel).IsUpdateClinic == true)
                {
                    ClinicList = service.GetAllClinics().ToList();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Can add clinic
        /// </summary>
        /// <returns></returns>
        private bool CanAddClinicExecute()
        {
            return true;
        }



        private ICommand editClinic;

        public ICommand EditClinic
        {
            get
            {
                if (editClinic == null)
                {
                    editClinic = new RelayCommand(param => EditClinicExecute(), param => CanEditClinicExecute());
                }
                return editClinic;
            }
        }
             
            
        public bool CanEditClinicExecute()
        {
            return true;
        }
        
        public void EditClinicExecute()
        {
            try
            {
                EditClinicView editClinicView = new EditClinicView(Clinic);
                editClinicView.ShowDialog();
                ClinicList = service.GetAllClinics();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
