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
    public partial class Info : Form
    {
        Controller controller;
        string gebruikersnaam;
        User user;
        Event evenement;
        Keuze keuze;

        #region constructors
        public Info(Event evt, User gebruiker, Keuze keuze)
        {
            user = gebruiker;
            ConstructorAlgemeen(evt, keuze);

            if (controller.AlreadySubscribed(gebruiker, evt) && keuze != Keuze.verleden)
                btnInschrijvenOfUitschrijven.Text = "Uitschrijven";
            
        }
        public Info(Event evt, string gebruikersnaam, Keuze keuze)
        {
            this.gebruikersnaam = gebruikersnaam;
            ConstructorAlgemeen(evt, keuze);

            if (gebruikersnaam == "")
                btnInschrijvenOfUitschrijven.Text = "OK";
        }
        #endregion constructors

        #region events
        private void btnInschrijvenOfUitschrijven_Click(object sender, EventArgs e)
        {
            if (btnInschrijvenOfUitschrijven.Text == "Uitschrijven")
            {
                controller.VerwijderEventFromUser(evenement, user);
                controller.VerminderAantalInschrijvingen(evenement);
            }
            else
            {
                if (btnInschrijvenOfUitschrijven.Text == "Inschrijven")
                {
                    SchrijfIn();
                }
                else
                    Close();
            }
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        #endregion events

        #region methods
        public void vulComponenten()
        {
            Event evnt = controller.leesEvent(evenement.EventId);
            txtAantal.Text = evnt.Subscriptions.ToString();
            txtEventNaam.Text = evnt.EventName;
            txtMax.Text = evnt.Maxsubscriptions.ToString();
            dtpDatum.Value = evnt.EventDate;
            txtOrganisator.Text = controller.getUsernameByUserID(evnt.Organisator);
            if (gebruikersnaam != "")
            {
                switch (keuze)
                {
                    case Keuze.verleden:
                        btnInschrijvenOfUitschrijven.Text = "OK";
                        break;
                    case Keuze.volzet:
                        if (controller.AlreadySubscribed(user, evnt))
                            btnInschrijvenOfUitschrijven.Text = "Uitschrijven";
                        else //kun je ooit hierin?
                            btnInschrijvenOfUitschrijven.Text = "OK";
                        break;
                    case Keuze.vrij:
                        if (controller.AlreadySubscribed(user, evnt))
                            btnInschrijvenOfUitschrijven.Text = "Inschrijven";
                        else
                            btnInschrijvenOfUitschrijven.Show();
                        break;
                    default:
                        break;
                }
            }
        }
        private void UnableCompnenten()
        {
            foreach (Control C in this.Controls)
            {
                if ((C.GetType() == typeof(TextBox)) || C.GetType() == typeof(DateTimePicker))
                {
                    C.Enabled = false;
                }
            }
        }
        private void SchrijfIn()
        {
            Event evt = GetLatestInfoEvent(evenement);
            if (AlreadySubscribed(user, evt))
            {
                MessageBox.Show("Je bent al ingeschreven voor dit Event!", "Dubbele inschrijving!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (IsEventFull(evt))
                {
                    MessageBox.Show("Helaas! Dit event is ondertussen volzet!", "Event volzet!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    controller.Inschrijven(user, evt);
                    controller.VermeerderAantalInschrijvingen(evt);
                }
            }
        }
        private Event GetLatestInfoEvent(Event evt)
        {
            return controller.GetLatestInfoEvent(evt);
        }
        private bool AlreadySubscribed(User ingelogdeUser, Event evt)
        {
            return controller.AlreadySubscribed(ingelogdeUser, evt);
        }
        private bool IsEventFull(Event evt)
        {
            if (evt.Subscriptions >= evt.Maxsubscriptions)
                return true;
            else
                return false;
        }
        private void ConstructorAlgemeen(Event evt,Keuze keuze)
        {
            InitializeComponent();
            controller = new Controller();
            evenement = evt;
            this.keuze = keuze;
            vulComponenten();
            UnableCompnenten();
        }
        #endregion methods

    }
}
