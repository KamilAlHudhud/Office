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
        #region Funkcja Pokaż siatkę
        private void pokaz_siatke(DataGridView siatka, TextBox txt_szukany)
        {
            //Pobieranie danych do tabeli
            MySqlConnection laczbaze = new MySqlConnection(Konfiguracja);
            MySqlCommand pobierz = new MySqlCommand("select iduzytkownik, imie as Imie,nazwisko as Nazwisko,login as Login , admin as Admin,haslo from Office.uzytkownik WHERE imie OR nazwisko OR login LIKE '%" + txt_szukany.Text + "%' ;", laczbaze);
            try
            {
                laczbaze.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = pobierz;
                DataTable dbdataset = new DataTable();
                adapter.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                siatka.DataSource = bSource;
                adapter.Update(dbdataset);
                laczbaze.Close();
                txt_szukany.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Szukaj/Ustawienia
        private void btn_Ustawienia_szukaj_Click(object sender, EventArgs e)
        {
            //Pobieranie danych do tabeli
            pokaz_siatke(dGV_Ustawienia, txtB_Ustawienia_szukaj);

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
            if (txtB_Imie.Text.Length <= 3 || txtB_Nazwisko.Text.Length <= 3 || txtB_Login.Text.Length <= 3 || txtB_Haslo.Text.Length <= 3)
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
                    dodaj.CommandText = "INSERT INTO office.uzytkownik SET login = '" + txtB_Login.Text + "', imie = '" + txtB_Imie.Text + "', nazwisko = '" + txtB_Nazwisko.Text + "', haslo = PASSWORD('" + txtB_Haslo.Text + "';";
                    dodaj.ExecuteNonQuery();
                    transakcja.Commit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    transakcja.Rollback();
                }
                laczbaze.Close();
                pokaz_siatke(dGV_Ustawienia, txtB_Ustawienia_szukaj);
            }

        }
        #endregion

        #region Modyfikowanie danych użytkownika/pracownika
        private void btn_Ustawienia_Modyfikuj_Click(object sender, EventArgs e)
        {
            if (txtB_Imie.Text.Length <= 3 || txtB_Nazwisko.Text.Length <= 3 || txtB_Login.Text.Length <= 3 || txtB_Haslo.Text.Length <= 3)
            {
                MessageBox.Show("Uzupełnij Dane!");
            }
            else
            {

                MySqlConnection laczbaze = new MySqlConnection(Konfiguracja);
                MySqlCommand modyfikuj = new MySqlCommand();
                MySqlTransaction transakcja;
                laczbaze.Open();
                transakcja = laczbaze.BeginTransaction(IsolationLevel.ReadCommitted);
                modyfikuj.Connection = laczbaze;
                modyfikuj.Transaction = transakcja;
                try
                {
                    modyfikuj.CommandText = "UPDATE office.uzytkownik SET login = '" + txtB_Login.Text + "', imie = '" + txtB_Imie.Text + "', nazwisko = '" + txtB_Nazwisko.Text + "', haslo = PASSWORD('" + txtB_Haslo.Text + "') WHERE iduzytkownik =" + id_rekordu + ";";
                    modyfikuj.ExecuteNonQuery();
                    transakcja.Commit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    transakcja.Rollback();
                }
                laczbaze.Close();
                pokaz_siatke(dGV_Ustawienia, txtB_Ustawienia_szukaj);
            }

        }
        #endregion

        #region Delete danych użytkownika/pracownika
        private void btn_Ustawienia_Usun_Click(object sender, EventArgs e)
        {
            if (id_rekordu == 1)
            {
                MessageBox.Show("Brak możliwości usunięcia Admina");
            }
            else
            {

                MySqlConnection laczbaze = new MySqlConnection(Konfiguracja);
                MySqlCommand delete = new MySqlCommand();
                MySqlTransaction transakcja;
                laczbaze.Open();
                transakcja = laczbaze.BeginTransaction(IsolationLevel.ReadCommitted);
                delete.Connection = laczbaze;
                delete.Transaction = transakcja;
                try
                {
                    if (MessageBox.Show("Czy napewno chcesz usunąć użytkownika?", "UWAGA!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        delete.CommandText = "DELETE FROM office.uzytkownik WHERE iduzytkownik =" + id_rekordu + ";";
                        delete.ExecuteNonQuery();
                        transakcja.Commit();
                        MessageBox.Show("Użytkownik został usunięty");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    transakcja.Rollback();
                }
                laczbaze.Close();
                pokaz_siatke(dGV_Ustawienia, txtB_Ustawienia_szukaj);
            }
        }
        #endregion

        #region szukanie usług
        private void btn_uslugi_szukaj_Click(object sender, EventArgs e)
        {
            pokaz_siatke_uslug();
        }
        private void pokaz_siatke_uslug()
        {
            //Pobieranie danych do tabeli uslug
            MySqlConnection laczbaze = new MySqlConnection(Konfiguracja);
            MySqlCommand pobierz = new MySqlCommand("SELECT * FROM office.uslugi WHERE Usluga OR Opis LIKE '%" + txt_uslugi_szukaj.Text + "%'  ;", laczbaze);
            try
            {
                laczbaze.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = pobierz;
                DataTable dbdataset = new DataTable();
                adapter.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dGV_Uslugi.DataSource = bSource;
                adapter.Update(dbdataset);
                laczbaze.Close();
                dGV_Uslugi.Columns[0].Visible = false;
                dGV_Uslugi.Columns[1].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Dodaj usługe
        private void btn_uslugi_dodaj_Click(object sender, EventArgs e)
        {
            if (txtB_usluga_usluga.Text.Length <= 3)
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
                    dodaj.CommandText = "INSERT INTO office.uslugi SET Usluga = '" + txtB_usluga_usluga.Text + "', Opis = '" + txt_usluga_opis.Text + "', Godzina = '" + txt_uslugi_godzina.Text + "', Dzien ='" + txt_uslugi_dzien.Text + "', Kto = '"+txtB_Wykonujacy.Text+"'  ;";
                    dodaj.ExecuteNonQuery();
                    transakcja.Commit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    transakcja.Rollback();
                }
                txt_uslugi_szukaj.Text = "";
                pokaz_siatke_uslug();

                laczbaze.Close();

            }
        }
        #endregion

        #region Pobranie z dGV Uslugi_Uslugi do textBoxów
        private void dGV_Uslugi_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id_rekordu = Convert.ToInt32(dGV_Uslugi.Rows[e.RowIndex].Cells[0].Value);
                txt_uslugi_godzina.Text = Convert.ToString(dGV_Uslugi.Rows[e.RowIndex].Cells[2].Value);
                txt_uslugi_dzien.Text = Convert.ToString(dGV_Uslugi.Rows[e.RowIndex].Cells[3].Value);
                txtB_usluga_usluga.Text = Convert.ToString(dGV_Uslugi.Rows[e.RowIndex].Cells[4].Value);
                txt_usluga_opis.Text = Convert.ToString(dGV_Uslugi.Rows[e.RowIndex].Cells[5].Value);
                txtB_Wykonujacy.Text = Convert.ToString(dGV_Uslugi.Rows[e.RowIndex].Cells[1].Value);
            }

        }
        #endregion

        #region Modyfikowanie usługi
        private void btn_uslugi_modyfikuj_Click(object sender, EventArgs e)
        {
            if (txtB_usluga_usluga.Text.Length <= 3)
            {
                MessageBox.Show("Uzupełnij Dane!");
            }
            else
            {
                MySqlConnection laczbaze = new MySqlConnection(Konfiguracja);
                MySqlCommand modyfikuj = new MySqlCommand();
                MySqlTransaction transakcja;
                laczbaze.Open();
                transakcja = laczbaze.BeginTransaction(IsolationLevel.ReadCommitted);
                modyfikuj.Connection = laczbaze;
                modyfikuj.Transaction = transakcja;
                try
                {
                    modyfikuj.CommandText = "UPDATE office.uslugi SET Usluga = '" + txtB_usluga_usluga.Text + "', Opis = '" + txt_usluga_opis.Text + "', Godzina = '" + txt_uslugi_godzina.Text + "', Dzien =" + txt_uslugi_dzien.Text + ",  Kto = '" + txtB_Wykonujacy.Text + "' WHERE iduslugi =" + id_rekordu + ";";
                    modyfikuj.ExecuteNonQuery();
                    transakcja.Commit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    transakcja.Rollback();
                }
                txt_uslugi_szukaj.Text = "";
                laczbaze.Close();
                pokaz_siatke_uslug();



            }
        }
        #endregion

        #region DELETE Uslugi
        private void btn_uslugi_usun_Click(object sender, EventArgs e)
        {

            MySqlConnection laczbaze = new MySqlConnection(Konfiguracja);
            MySqlCommand delete = new MySqlCommand();
            MySqlTransaction transakcja;
            laczbaze.Open();
            transakcja = laczbaze.BeginTransaction(IsolationLevel.ReadCommitted);
            delete.Connection = laczbaze;
            delete.Transaction = transakcja;
            try
            {
                if (MessageBox.Show("Czy napewno chcesz usunąć usługę?", "UWAGA!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    delete.CommandText = "DELETE FROM office.uslugi WHERE iduslugi =" + id_rekordu + ";";
                    delete.ExecuteNonQuery();
                    transakcja.Commit();
                    MessageBox.Show("Usługa została usunięta");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                transakcja.Rollback();
            }
            laczbaze.Close();
            pokaz_siatke_uslug();

        }
        #endregion



    }
}

