using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Kontoverwaltung
{
    public partial class Register : Form
    {
        private Hauptfenster _Hauptfenster;
        private Regex _Password = new Regex("^(?=.*[a-z].*)(?=.*[A-Z].*)(?=.*[0-9].*)(?=.*\\W.*).{8,}$");
        public Register(Hauptfenster mainWin)
        {
            InitializeComponent();
            _Hauptfenster = mainWin;
        }

        private void Register_Load(object sender, EventArgs e)
        {
            Location = new Point(_Hauptfenster.Location.X, _Hauptfenster.Location.Y);
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Hauptfenster.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                Kundenverwaltung.LegeKundeAn(GetUserName(), GetLoginName(), GetPassword());
            }
            catch (ArgumentException ae)
            {
                registerMeldungen.ForeColor = Color.Red;
                registerMeldungen.Text = "Fehler: " + ae.Message;
                return;
            }

            registerMeldungen.ForeColor = Color.Green;
            registerMeldungen.Text = "Konto erfolgreich Angelegt";
            registerMeldungen.Refresh();

            Thread.Sleep(1000);
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string GetUserName()
        {
            if (tbrUserName.Text.IsWhiteSpace()) throw new ArgumentException("Username darf nicht leer sein");
            else return tbrUserName.Text;
        }

        private string GetLoginName()
        {
            if (tbLoginName.Text.IsWhiteSpace()) throw new ArgumentException("Login-Name darf nicht leer sein");
            if (LoginNameExsist(tbLoginName.Text)) throw new ArgumentException("Login-Name exsistiert bereits");
            else return tbLoginName.Text;
        }

        private string GetPassword()
        {
            if (!_Password.IsMatch(tbLoginPassword.Text)) throw new ArgumentException("Passwort Entspricht nicht den Anforderungen");
            else return tbLoginPassword.Text;
        }

        private bool LoginNameExsist(string name)
        {
            foreach (var kunde in Kundenverwaltung.kunden)
            {
                if (kunde.LoginName == name) { return true; }
            }
            return false;
        }
    }
}
