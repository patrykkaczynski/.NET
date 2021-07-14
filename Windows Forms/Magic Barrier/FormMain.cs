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
    public partial class FormMain : Form
    {
        #region zmienne
        /// <summary>
        /// Zmienna przechowujaca referencje do okna gdzie rozpoczynamy rozgrywke
        /// </summary>
        FormNew formNew;
        /// <summary>
        /// Zmienna przechowujaca obrazek ktora zostanie przeslana podczas wywolywania konstruktora dla nowego okna
        /// </summary>
        Image selectedHero;
        /// <summary>
        /// Zmienna przechowujaca imie postaci
        /// </summary>
        string heroName;
        /// <summary>
        /// Zmienne przechowujace bonusy po wyborze konkretnej postaci
        /// </summary>
        int bonus1;
        int bonus2;
        /// <summary>
        /// Zmienna przechowujaca referencje do okna gdzie jest umieszczony opis gry
        /// </summary>
        FormGameRules formGameRules;
        #endregion

        public FormMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Funkcja tworzaca nowe okno w ktorej rozpoczynamy rozgrywke
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGameWindow_Click(object sender, EventArgs e)
        {
            //warunkek sprawdzajacy czy postać została wybrana
            if (radioButtonDiego.Checked == true || radioButtonMilten.Checked == true || radioButtonGorn.Checked == true || radioButtonLester.Checked == true)
            {
                //utworzenie nowego obiektu okna FormNew
                formNew = new FormNew(selectedHero, heroName, bonus1, bonus2);
                //otworzenie okna obiektu formNew
                formNew.Show();
            }
            else
            {
                //jesli warunek nie jest spelniony pokazuj wiadomosc
                MessageBox.Show("Przed rozpoczęciem gry należy wybrać postać!");
            }
        }
        /// <summary>
        /// Wybranie postaci Diego
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonDiego_CheckedChanged(object sender, EventArgs e)
        {
            //przypisanie obrazka dla postaci Diego do zmiennej odpowiedzialnej za przechowywanie obrazek i przekazywanej do nowego okna przy wywolywania konstruktora dla nowego okna
            selectedHero = pictureBoxDiego.Image;
            //przypisanie nazwy postaci do elementu labelHeroName
            labelHeroName.Text = "Diego";
            //przypisanie nazwy postaci do zmiennej heroName
            heroName = labelHeroName.Text;
            //przypisanie opisu postaci do elementu labelDescription.Text
            labelDescription.Text = "Diego jest sprytnym człowiekiem zawsze szukającym okazji, by się wzbogacić. Ma żyłkę do interesów i nie wzbrania się skorzystać z nieuczciwej okazji do zarobku, jest też jednak honorowy i lojalny wobec swoich przyjaciół. Bardzo inteligentny, potrafi się dobrze ustawić w życiu i wyjść cało z niejednej opresji.";
            //przypisanie tekstu okreslajacego jakie bonusy otrzymuje uzytkownik po wyborze okreslonej postaci
            labelDescriptionBonus1.Text = "Liczba bryłek rudy: ";
            labelDescriptionBonus2.Text = "Liczba kopaczy: ";
            //przypisanie wartosci bonusowych do zmiennych dla konkretnej postaci
            bonus1 = 100;
            bonus2 = 5;
            //wywietlanie bonusow dla elementow labelValueBonus1 i labelValueBonus2 (zamiana typu z int na string)
            labelValueBonus1.Text = bonus1.ToString();
            labelValueBonus2.Text = bonus2.ToString();
        }
        /// <summary>
        /// Wybranie postaci Milten
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonMilten_CheckedChanged(object sender, EventArgs e)
        {
            //przypisanie obrazka dla postaci Milten do zmiennej odpowiedzialnej za przechowywanie obrazek i przekazywanej do nowego okna przy wywolywania konstruktora dla nowego okna
            selectedHero = pictureBoxMilten.Image;
            //przypisanie nazwy postaci do elementu labelHeroName
            labelHeroName.Text = "Milten";
            //przypisanie nazwy postaci do zmiennej heroName
            heroName = labelHeroName.Text;
            //przypisanie opisu postaci do elementu labelDescription.Text
            labelDescription.Text = "Milten jest szczerym i uczciwym człowiekiem oraz oddanym przyjacielem. Nigdy nie zapomina o ludziach, którzy mu pomogli. Jako mag ognia chętnie widziałby Bezimiennego w roli sługi Innosa, jednak szanuje dokonywane przez niego wybory. Na skutek doświadczeń nabytych w życiu jest nad wiek dojrzały.";
            //przypisanie tekstu okreslajacego jakie bonusy otrzymuje uzytkownik po wyborze okreslonej postaci
            labelDescriptionBonus1.Text = "Liczba run ognia: ";
            labelDescriptionBonus2.Text = "Liczba magów ognia: ";
            //przypisanie wartosci bonusowych do zmiennych dla konkretnej postaci
            bonus1 = 2;
            bonus2 = 1;
            //wywietlanie bonusow dla elementow labelValueBonus1 i labelValueBonus2 (zamiana typu z int na string)
            labelValueBonus1.Text = bonus1.ToString();
            labelValueBonus2.Text = bonus2.ToString();
        }
        /// <summary>
        /// Wybranie postaci Gorn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonGorn_CheckedChanged(object sender, EventArgs e)
        {
            //przypisanie obrazka dla postaci Gorn do zmiennej odpowiedzialnej za przechowywanie obrazek i przekazywanej do nowego okna przy wywolywania konstruktora dla nowego okna
            selectedHero = pictureBoxGorn.Image;
            //przypisanie nazwy postaci do elementu labelHeroName
            labelHeroName.Text = "Gorn";
            //przypisanie nazwy postaci do zmiennej heroName
            heroName = labelHeroName.Text;
            //przypisanie opisu postaci do elementu labelDescription.Text
            labelDescription.Text = "Gorn jest silny, zręczny oraz bardzo szybki, lubi również wiedzieć, co ma za plecami. Zawsze walczy ogromnymi toporami dwuręcznymi.";
            //przypisanie tekstu okreslajacego jakie bonusy otrzymuje uzytkownik po wyborze okreslonej postaci
            labelDescriptionBonus1.Text = "Liczba run wody: ";
            labelDescriptionBonus2.Text = "Liczba strażników: ";
            //przypisanie wartosci bonusowych do zmiennych dla konkretnej postaci
            bonus1 = 1;
            bonus2 = 3;
            //wywietlanie bonusow dla elementow labelValueBonus1 i labelValueBonus2 (zamiana typu z int na string)
            labelValueBonus1.Text = bonus1.ToString();
            labelValueBonus2.Text = bonus2.ToString();

        }
        /// <summary>
        /// Wybranie postaci Lester
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonLester_CheckedChanged(object sender, EventArgs e)
        {
            //przypisanie obrazka dla postaci Lester do zmiennej odpowiedzialnej za przechowywanie obrazek i przekazywanej do nowego okna przy wywolywania konstruktora dla nowego okna
            selectedHero = pictureBoxLester.Image;
            //przypisanie nazwy postaci do elementu labelHeroName
            labelHeroName.Text = "Lester";
            //przypisanie nazwy postaci do zmiennej heroName
            heroName = labelHeroName.Text;
            //przypisanie opisu postaci do elementu labelDescription.Text
            labelDescription.Text = "Lester jest uprzejmym człowiekiem o raczej łagodnym usposobieniu. Jest dość sceptyczny względem rozmaitych ideologii, jednak nie przeszkadza mu to w chwilowym popieraniu ich w celu osiągnięcia większego dobra. Jako przyjaciel jest oddany i można na nim polegać.";
            //przypisanie tekstu okreslajacego jakie bonusy otrzymuje uzytkownik po wyborze okreslonej postaci
            labelDescriptionBonus1.Text = "Liczba kamieni runicznych: ";
            labelDescriptionBonus2.Text = "Liczba alchemików: ";
            //przypisanie wartosci bonusowych do zmiennych dla konkretnej postaci
            bonus1 = 4;
            bonus2 = 2;
            //wywietlanie bonusow dla elementow labelValueBonus1 i labelValueBonus2 (zamiana typu z int na string)
            labelValueBonus1.Text = bonus1.ToString();
            labelValueBonus2.Text = bonus2.ToString();
        }
        /// <summary>
        /// Funkcja tworzaca nowe okno w ktorej znajduje sie opis gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGameRules_Click(object sender, EventArgs e)
        {
            //utworzenie nowego obiektu okna FormGameRules
            formGameRules = new FormGameRules();
            //otworzenie okna obiektu formGameRules
            formGameRules.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
