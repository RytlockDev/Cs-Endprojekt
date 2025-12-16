using Microsoft.Win32;

namespace Kontoverwaltung
{
    public partial class Hauptfenster : Form
    {
        public Hauptfenster()
        {
            InitializeComponent();
        }

        private void Hauptfenster_Load(object sender, EventArgs e)
        {
            Location = new Point(Screen.PrimaryScreen.Bounds.Width / 4 - this.Width / 2, Screen.PrimaryScreen.Bounds.Height / 4 - this.Height / 2);
        }

        private void Hauptfenster_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e) {
            Kunde benutzer = Kundenverwaltung.UserIsAuthorized(tbLoginName.Text, tbLoginPassword.Text);
            if (benutzer != null)
            {
                KontoPortal portal = new KontoPortal(this, benutzer);
                portal.Show();
                this.Hide();
            } else {
                meldungen.ForeColor = Color.Red;
                meldungen.Text = "Login Daten stimmen nciht uebererein";
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register(this);
            register.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
