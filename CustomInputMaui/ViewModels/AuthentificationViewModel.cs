using CustomInputMaui.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace CustomInputMaui.ViewModels
{
    public class AuthentificationViewModel : BindableObject, INotifyPropertyChanged
    {
        #region Attribute 

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
        
        public AuthentificationViewModel()
        {
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

                    //  i will  call apis in this  and i will check
                    //  about  resulte  of  api  if user  connectced
                    //  i will move it  to  devices screen
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
