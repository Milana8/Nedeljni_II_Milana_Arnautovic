using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Zadatak_1.Command;
using Zadatak_1.Model;
using Zadatak_1.View;

namespace Zadatak_1.ViewModel
{
    class LoginViewModel : ViewModelBase
    {
        LoginView view;
        Service service = new Service();


        #region Constructors

        public LoginViewModel(LoginView view)
        {
            this.view = view;
            administrator = new vwAdministrator();
            AdminList = service.GetAllAdministratorView().ToList();

        }
        #endregion

        #region Property

        private string userName;
        public string UserName
        {

            get
            {
                return userName;
            }
            set
            {
                userName = value;
                OnPropertyChanged("UserName");
            }
        }
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


        #endregion

        #region Commands
        private ICommand login;
        /// <summary>
        /// Command login
        /// </summary>
        public ICommand Login
        {
            get
            {
                if (login == null)
                {
                    login = new RelayCommand(LoginExecute);
                }
                return login;
            }
            set { login = value; }
        }
        /// <summary>
        /// Method for checking username and password
        /// </summary>
        /// <param name="o"></param>
        private void LoginExecute(object o)
        {

            try
            {
                StreamReader sr = new StreamReader(@"..\..\ClinicAccess.txt");
                string line = "";
                List<string> clinic = new List<string>();

                while ((line = sr.ReadLine()) != null)
                {
                    clinic.Add(line);
                }
                sr.Close();
                string password = (o as PasswordBox).Password;
                if (userName == clinic[0] && password == clinic[1])
                {
                    AddClinicAdministratorView cl = new AddClinicAdministratorView();
                    view.Close();
                    cl.ShowDialog();
                }
                else if (service.IsUser(UserName))
                {
                    Administrator = service.FindAdmin(UserName);
                    AdministratorView adminView = new AdministratorView();
                    view.Close();
                    adminView.ShowDialog();
                    
                }


                else
                {
                    MessageBox.Show("Incorrect username or password. Please try again.");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

    }
}
