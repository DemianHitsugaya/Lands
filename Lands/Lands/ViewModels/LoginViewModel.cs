using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using Xamarin.Forms;

namespace Lands.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {

        #region Attributes
        private string email;
        private string password;
        private bool isrunning;
        private bool isEnabled;
        #endregion

        #region Properties
        public string Email {
            get { return this.email; }
            set { SetValue(ref this.email, value); }
        }
        public string Password
        {
            get { return this.password; }
            set { SetValue(ref this.password, value); }
        }
        public bool IsRemember { get; set; }
        public bool IsRunning
        {
            get { return this.isrunning; }
            set { SetValue(ref this.isrunning, value); }
        }
        public bool IsEnabled
        {
            get { return this.isEnabled; }
            set { SetValue(ref this.isEnabled, value); }
        }
        #endregion

        #region Commands
        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(Login);
            }
        }



        private async void Login()
        {
            this.IsRunning =true;
            this.IsEnabled = false;

            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Digite un email", "Aceptar");
                return;
            }

            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Digite su password", "Aceptar");
                return;
            }
            if (this.Email != "rortegla@misena.edu.co" || this.Email != "123456")
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Email o password incorrecto", "Aceptar");
                return;
            }


            await Application.Current.MainPage.DisplayAlert("OK", "Successfull Login", "Aceptar");

        }
        #endregion

        #region Constructors
        public LoginViewModel()
        {
            this.IsRemember = this.IsEnabled = true;
        }
        #endregion
    }
}
