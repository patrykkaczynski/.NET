using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatrykKaczynskiLab1ZadDom
{
    public partial class FormGameRules : Form
    {
        public FormGameRules()
        {
            InitializeComponent();
        }

        private void FormGameRules_Load(object sender, EventArgs e)
        {
            //przypisane tekstu - opisu gry do elementu labelGameDescriptionContent
            labelGameDescriptionContent.Text = "Gra nawiązuje do serii Gothic (części pierwszej Gothica), w której to Bezimienny wrzucony do kolonii karnej (Górniczej Doliny) robił wszystko aby zniszczyć magiczną barierę i wydostać się z przeklętego miejsca. W grze wybieramy jednego z dobrych przyjaciół bezimiennego (Diego, Miltena, Gorna lub Lestera) posiadających indywidualne bonusy początkowe ułatwiające rozgrywkę. Warunkiem ukończenia gry jest zebranie 5000 bryłek rudy oraz pozyskanie 13 magów (6 magów ognia, 6 magów wody, 1 nekromanty) w celu detonacji kopca rudy. W czasie rozgrywki czekają na gracza zdarzenia negatywne i pozytywne uzależnione od czasu i obecnego stanu zasobów w danym czasie.";
        }
        /// <summary>
        /// Przycisk zamykajacy okno z opisem gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCloseWindow_Click(object sender, EventArgs e)
        {
            //schowanie okna z opisem gry
            this.Hide();
        }
    }
}
