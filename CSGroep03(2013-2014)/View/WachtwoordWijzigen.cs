using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSGroep03_2013_2014_
{
    public partial class WachtwoordWijzigen : Form
    {
        User gebruiker;
        Controller controller;
        
        public WachtwoordWijzigen(User gebruiker)
        {
            InitializeComponent();
            controller = new Controller();
            this.gebruiker = gebruiker;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if(controller.checkGebruikersnaamEnWachtwoord(gebruiker.UserName,txtOudWachtwoord.Text))
            {
                errorOudWachtwoord.SetError(txtOudWachtwoord, "");
                if (txtNieuwWachtwoord.Text != txtNieuwWachtwoord2.Text)
                    errorNieuwWachtwoord.SetError(txtNieuwWachtwoord2, "Nieuw wachtwoord komen niet overeen");
                else
                {
                    errorNieuwWachtwoord.SetError(txtNieuwWachtwoord2, "");
                    controller.UpdateUser(txtNieuwWachtwoord2.Text, gebruiker.UserName);
                }
            }
            else
                errorOudWachtwoord.SetError(txtOudWachtwoord,"Wachtwoord komt niet overeen met gebruiker "+gebruiker.UserName);
            
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
