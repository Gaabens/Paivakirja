using Microsoft.VisualBasic.ApplicationServices;

namespace Paivakirja
{
    public partial class DiaryForm : Form
    {
        public DiaryForm()
        {
            InitializeComponent();
        }

        private void TallennaBT_Click(object sender, EventArgs e)
        {
            string teksti = File.ReadAllText(@"c:\\Users\\gabriel.savinen\\OneDrive - Keski - Uudenmaan koulutuskuntayhtymä\\Harjoitukset\\Paivakirja\\demo.txt");
            teksti += SyottoTB.Text;
            teksti += " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "\n";

            TextWriter text = new StreamWriter("c:\\Users\\gabriel.savinen\\OneDrive - Keski - Uudenmaan koulutuskuntayhtymä\\Harjoitukset\\Paivakirja\\demo.txt");
            text.Write(teksti);
            text.Close();
            Application.Exit();
        }
    }
}
