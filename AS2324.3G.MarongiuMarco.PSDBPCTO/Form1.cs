using System.Data.SQLite;
using System.Data;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;

namespace AS2324._3G.MarongiuMarco.PSDBPCTO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPiloti_Click(object sender, EventArgs e)
        {
            string query = "";
            string strConnessione = "";
            strConnessione = "Data Source=" + @"C:\Users\coent\OneDrive\Documenti\compiti informatica\windows form\AS2324.3G.MarongiuMarco.PSDBPCTO\AS2324.3G.MarongiuMarco.PSDBPCTO\DB\MotoGP.db" + ";Version=3;";
            DataTable dtDati = new DataTable();

            query = "SELECT * FROM Piloti WHERE nazionalita = 'ITA' ORDER by nome, cognome";


            SQLiteDataAdapter da = new SQLiteDataAdapter(query, strConnessione);

            try
            {
                // riempie il DataTable
                da.Fill(dtDati);

                // binda la DataGridView
                dgvDB.DataSource = dtDati;
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }

        }

        private void btnGare_Click(object sender, EventArgs e)
        {
            //Un bottone Elenco Gare con l'estrazione in griglia
            //delle gare andate a podio ordinati per circuito e punteggio

            string query = "";
            string strConnessione = "";
            strConnessione = "Data Source=" + @"C:\Users\coent\OneDrive\Documenti\compiti informatica\windows form\AS2324.3G.MarongiuMarco.PSDBPCTO\AS2324.3G.MarongiuMarco.PSDBPCTO\DB\MotoGP.db" + ";Version=3;";
            DataTable dtDati = new DataTable();

            query = "SELECT * FROM Gare WHERE Punteggio >=1 AND Punteggio<=3 ORDER by Circuiti, Punteggio";


            SQLiteDataAdapter da = new SQLiteDataAdapter(query, strConnessione);

            try
            {
                // riempie il DataTable
                da.Fill(dtDati);

                // binda la DataGridView
                dgvDB.DataSource = dtDati;
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }
    }
}