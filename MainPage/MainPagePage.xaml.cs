using System;
using Xamarin.Forms;

namespace MainPage
{
    public partial class MainPagePage : ContentPage
    {
        SettingsPage sp;

        public MainPagePage()
        {
            InitializeComponent();
            sp = new SettingsPage();
        }

        private void btnSend_Clicked(object sender, EventArgs e){
            
            if (sp.Receive){
                DisplayAlert("Message", string.Format("E-mail sent successfully to {0}", sp.Mail), "OK");
            } else {
                DisplayAlert("Message", "E-mail will not be send.", "OK");
            }
        }

        private void btnSettings_Clicked(object sender, EventArgs e){

            Navigation.PushAsync(sp);
        }


    }
}
