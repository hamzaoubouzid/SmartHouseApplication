using CustomInputMaui.Models;
using CustomInputMaui.Views;
using System.ComponentModel;
using System.Windows.Input;

namespace CustomInputMaui.ViewModels
{
    public class AuthentificationViewModel : BindableObject,INotifyPropertyChanged
    {
        #region Attribute 
        public INavigation Navigation { get; set; }

        private string _Email;
        public string Email
        {
            get { return _Email; }
            set
            {
                if (_Email != value)
                {
                    _Email = value;
                    OnPropertyChanged(nameof(Email));
                }
            }
        }

        private string _Password;
        public string Password
        {
            get { return _Password; }
            set
            {
                if (_Password != value)
                {
                    _Password = value;
                    OnPropertyChanged(nameof(Password));
                }
            }
        }

        #endregion

        #region Contractor
        
        public AuthentificationViewModel(INavigation navigation)
        {
            this.Navigation = navigation;
        }

        #endregion

        #region Commands
        
        private bool CanLogin = true;
        public ICommand LoginCommand => new Command(async () =>
        {
            try
            {
                CanLogin = false;

                if (!string.IsNullOrEmpty(Email) && 
                !string.IsNullOrEmpty(Password))
                {
                    var userdata = new Account()
                    {
                        Email = Email,
                        Password = Password
                    };

                    Application.Current.MainPage = new NavigationPage(new DashbordPage());
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "Thank you for filling in the fields", "OK");
                }
            }
            catch (Exception ex)
            {
                // Handle exception
            }
            finally
            {

            }
        }, () => CanLogin);

        #endregion
    }
}
