using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Office
{

    public partial class Form_logowanie : Form
    {
        String Konfiguracja = "datasource=localhost;port=3306;username=root;password=kamil123;database=Office";

        public Form_logowanie()
        {
            InitializeComponent();
        }

        private void Form_logowanie_Load(object sender, EventArgs e)
        {

        }

#region Logowanie
        private void btn_zaloguj_Click(object sender, EventArgs e)
        {
           
            MySqlConnection laczbaze = new MySqlConnection(Konfiguracja);
            MySqlCommand logowanie = new MySqlCommand("SELECT iduzytkownik FROM office.uzytkownik WHERE login = '"+txtB_login.Text+"' AND haslo = PASSWORD('"+txtB_haslo.Text+"');", laczbaze);
            MySqlDataReader odczytywanie;

          
                try
                {
                 //Otwieranie Menu główne & zamykanie Login 
                    laczbaze.Open();
                    odczytywanie = logowanie.ExecuteReader();

                    if (odczytywanie.Read())
                    {
                        Menu_Glowne Druga = new Menu_Glowne();
                        Druga.Show();
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Błędny Login lub Hasło");
                    }
                }
                catch (Exception Ex)
                {
                    Console.WriteLine(Ex.Message);
                }
                laczbaze.Close();
        }
        
#endregion
    }
}
