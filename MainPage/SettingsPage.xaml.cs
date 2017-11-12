using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MainPage
{
    public partial class SettingsPage : ContentPage
    {
        bool receive;
        String mail;

        public SettingsPage()
        {
            InitializeComponent();
            receive = swCell.On;
        }

        public bool Receive{
            get{
                return receive;
            }

            set{
                receive = value;
            }
        }

        public String Mail
        {
            get
            {
                return mail;
            }

            set
            {
                mail = value;
            }
        }

        public void swReceive_Switched(object sender, EventArgs e){
            if (swCell.On){
                receive = true;
                txtMail.IsEnabled = true;
            } else {
                receive = false;
                txtMail.IsEnabled = false;
            }

        }

        public void txtName_Completed(object sender, EventArgs e){
            mail = txtMail.Text;
        }
    }
}
