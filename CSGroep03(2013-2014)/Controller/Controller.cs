using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGroep03_2013_2014_
{
    class Controller
    {
        DataBank db;

        public Controller()
        {
            db = DataBank.DatabankInstantie;
        }

        public List<Event> leesEventsverleden()
        {
            return db.leesEventsverleden();
        }
        public List<Event> leesEventsToekomstVolzet()
        {
            return db.leesEventsToekomstvolzet();
        }
        public List<Event> leesEventsToekomstvrij()
        {
            return db.leesEventsToekomstvrij();
        }
        public Event leesEvent(int eventID)
        {
            return db.LeesEvent(eventID);
        }
        public List<Event> leesMijnEvents(User user)
        {
            return db.leesMijnEvents(user);
        }

        public void NieuwEvent(Event events)
        {
            db.NieuwEvent(events);
        }
        public void VerminderAantalInschrijvingen(Event evt)
        {
            db.VerminderAantalInschrijvingen(evt);
        }
        public void VermeerderAantalInschrijvingen(Event evt)
        {
            db.VermeerderAantalInschrijvingen(evt);
        }
        public Event GetLatestInfoEvent(Event evt)
        {
            return db.GetLatestInfoEvent(evt);
        }

        public void VerwijderEventFromUser(Event evenement, User user)
        {
            db.VerwijderEventFromUser(user, evenement);
        }
        public void Inschrijven(User user, Event evt)
        {
            db.Inschrijven(user, evt);
        }
        public User getUser(string gebruikersnaam, string wachtwoord)
        {
            return db.getUser(gebruikersnaam, wachtwoord);
        }
        public void addUser(string gebruikersnaam, string wachtwoord)
        {
            db.addUser(gebruikersnaam, wachtwoord);
        }
        public string getUsernameByUserID(int organisator)
        {
            return db.getUsernameByUserID(organisator);
        }
        public void UpdateUser(string wachtwoord, string gebruikersnaam)
        {
            db.UpdateUser(wachtwoord, gebruikersnaam);
        }

        public bool checkGebruikersnaamEnWachtwoord(string Gebruikersnaam, string Wachtwoord)
        {
            return db.checkGebruikersnaamEnWachtwoord(Gebruikersnaam, Wachtwoord);
        }
        public bool checkDuplicatieGebruikersnaam(string Gebruikersnaam)
        {
            return db.checkDuplicatieGebruikersnaam(Gebruikersnaam);
        }
        public bool AlreadySubscribed(User ingelogdeUser, Event evt)
        {
            return db.AlreadySubscribed(ingelogdeUser, evt);
        }

        
    }
}
