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
        int id_rekordu; //zapisanie w zmiennej id rekorku
        public Menu_Glowne()
        {
            InitializeComponent();
        }
        #region Szukaj/Ustawienia
        private void btn_Ustawienia_szukaj_Click(object sender, EventArgs e)
        {
            //Pobieranie danych do tabeli
            MySqlConnection laczbaze = new MySqlConnection(Konfiguracja);
            MySqlCommand pobierz = new MySqlCommand("select iduzytkownik, imie as Imie,nazwisko as Nazwisko,login as Login , admin as Admin,haslo from Office.uzytkownik WHERE imie OR nazwisko OR login LIKE '%" + txtB_Ustawienia_szukaj.Text + "%' ;", laczbaze);
            try
            {
                laczbaze.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = pobierz;
                DataTable dbdataset = new DataTable();
                adapter.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dGV_Ustawienia.DataSource = bSource;
                adapter.Update(dbdataset);
                laczbaze.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //Ukrycie iduzytkownika oraz hasla
            dGV_Ustawienia.Columns[0].Visible = false;
            dGV_Ustawienia.Columns[5].Visible = false;
        }
        #endregion

        #region Pobieranie danych z DGV do textboxów 
        private void dGV_Ustawienia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id_rekordu = Convert.ToInt32(dGV_Ustawienia.Rows[e.RowIndex].Cells[0].Value);
                txtB_Imie.Text = Convert.ToString(dGV_Ustawienia.Rows[e.RowIndex].Cells[1].Value);
                txtB_Nazwisko.Text = Convert.ToString(dGV_Ustawienia.Rows[e.RowIndex].Cells[2].Value);
                txtB_Login.Text = Convert.ToString(dGV_Ustawienia.Rows[e.RowIndex].Cells[3].Value);
                txtB_Haslo.Text = Convert.ToString(dGV_Ustawienia.Rows[e.RowIndex].Cells[5].Value);
            }
        }
        #endregion

        #region Dodawanie nowych użytkowników
        private void btn_Ustawienia_Dodaj_Click(object sender, EventArgs e)
        {
            if (txtB_Imie.Text.Length <=3 || txtB_Nazwisko.Text.Length <= 3 || txtB_Login.Text.Length <= 3 || txtB_Haslo.Text.Length <= 3)
            {
                MessageBox.Show("Uzupełnij Dane!");
            }
            else
            {

            MySqlConnection laczbaze = new MySqlConnection(Konfiguracja);
            MySqlCommand dodaj = new MySqlCommand();
            MySqlTransaction transakcja;
            laczbaze.Open();
            transakcja = laczbaze.BeginTransaction(IsolationLevel.ReadCommitted);
            dodaj.Connection = laczbaze;
            dodaj.Transaction = transakcja;
                try
                { 
                    dodaj.CommandText = "INSERT INTO office.uzytkownik SET login = '" + txtB_Login.Text + "', imie = '" + txtB_Imie.Text + "', nazwisko = '" + txtB_Nazwisko.Text + "', haslo = PASSWORD('" + txtB_Haslo.Text + "');";
                    dodaj.ExecuteNonQuery();
                    transakcja.Commit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    transakcja.Rollback();
                }
                laczbaze.Close();
            }
            #endregion
        }
    }
}

