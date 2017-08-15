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
   

    public partial class Menu_Glowne : Form
    {
     String Konfiguracja = "datasource=localhost;port=3306;username=root;password=kamil123;database=Office";

        public Menu_Glowne()
        {
            InitializeComponent();
        }
#region Szukaj/Ustawienia
        private void btn_Ustawienia_szukaj_Click(object sender, EventArgs e)
        {
          //Pobieranie danych do tabeli
            MySqlConnection laczbaze = new MySqlConnection(Konfiguracja);
            MySqlCommand pobierz = new MySqlCommand("select imie as Imie,nazwisko as Nazwisko,login as Login , admin as Admin from Office.uzytkownik WHERE imie OR nazwisko OR login LIKE '%"+txtB_Ustawienia_szukaj.Text+"%' ;", laczbaze);
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = pobierz;
                DataTable dbdataset = new DataTable();
                adapter.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dGV_Ustawienia.DataSource = bSource;
                adapter.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
#endregion
    }
}
