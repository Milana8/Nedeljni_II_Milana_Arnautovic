using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Zadatak_1.Command;
using Zadatak_1.View;

namespace Zadatak_1.ViewModel
{
    class AdministratorViewModel: ViewModelBase
    {
        AdministratorView aView;

        public AdministratorViewModel(AdministratorView aView)
        {
            this.aView = aView;
        }

        private ICommand clinic;

        public ICommand Clinic
        {
            get
            {
                if (clinic == null)
                {
                    clinic = new RelayCommand(param => ClinicExecute(), param => CanClinicExecute());
                }
                return clinic;
            }
        }

        public bool CanClinicExecute()
        {
            return true;
        }

        public void ClinicExecute()
        {
            ClinicView clinicView = new ClinicView();
            clinicView.ShowDialog();
        }

        private ICommand doctor;

        public ICommand Doctor
        {
            get
            {
                if (doctor == null)
                {
                    doctor = new RelayCommand(param => DoctorExecute(), param => CanDoctorExecute());
                }
                return doctor;
            }
        }

        public bool CanDoctorExecute()
        {
            return true;
        }

        public void DoctorExecute()
        {
            DoctorView doctorView = new DoctorView();
            doctorView.ShowDialog();
        }

        private ICommand patient;

        public ICommand Patient
        {
            get
            {
                if (patient == null)
                {
                    patient = new RelayCommand(param => PatientExecute(), param => CanPatientExecute());
                }
                return patient;
            }
        }

        public bool CanPatientExecute()
        {
            return true;
        }

        public void PatientExecute()
        {
            PatientView patientView = new PatientView();
            patientView.ShowDialog();
        }

        private ICommand manager;

        public ICommand Manager
        {
            get
            {
                if (manager == null)
                {
                    manager = new RelayCommand(param => ManagerExecute(), param => CanManagerExecute());
                }
                return manager;
            }
        }

        public bool CanManagerExecute()
        {
            return true;
        }

        public void ManagerExecute()
        {
            ManagerView managerView = new ManagerView();
            managerView.ShowDialog();
        }

        private ICommand maintenance;

        public ICommand Maintenance
        {
            get
            {
                if (maintenance == null)
                {
                    maintenance = new RelayCommand(param => MaintenanceExecute(), param => CanMaintenanceExecute());
                }
                return maintenance;
            }
        }

        public bool CanMaintenanceExecute()
        {
            return true;
        }

        public void MaintenanceExecute()
        {
            MaintenanceView maintenanceView = new MaintenanceView();
            maintenanceView.ShowDialog();
        }


      
    }
}
