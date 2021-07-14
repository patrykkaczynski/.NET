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
    public partial class FormNew : Form
    {
        #region
        /// <summary>
        /// Zmienna obslugujaca licznik zegara
        /// </summary>
        int counter = 0;
        /// <summary>
        /// Zmienna przechowujaca zdjecie postaci z glownego okna podczas wywolywania konstruktora dla nowego okna 
        /// </summary>
        public Image selectedHeroImage;
        /// <summary>
        /// Zmienna przechowujaca liczbe brylek rudy
        /// </summary>
        int counterMagicOre = 1000;
        /// <summary>
        /// Zmienna przechowujaca liczbe kamieni runicznych
        /// </summary>
        int counterRunicStone;
        /// <summary>
        /// Zmienna przechowujaca liczbe kopaczy
        /// </summary>
        int counterDigger = 0;
        /// <summary>
        /// Zmienna przechowujaca liczbe alchemikow
        /// </summary>
        /// <param name="image"></param>
        int counterAlchemist = 0;
        /// <summary>
        /// Zmienna przechowujaca liczbe straznikow
        /// </summary>
        int counterGuard = 0;
        /// <summary>
        /// Zmienna przechowujaca liczbe run ognia
        /// </summary>
        int counterFireRune = 0;
        /// <summary>
        /// Zmienna przechowujaca liczbe run wody
        /// </summary>
        int counterWaterRune = 0;
        /// <summary>
        /// Zmienna przechowujaca liczbe run nekromancji
        /// </summary>
        int counterNecromancyRune = 0;
        /// <summary>
        /// Zmienna przechowujaca liczbe magow ognia
        /// </summary>
        int counterFireMage = 0;
        /// <summary>
        /// Zmienna przechowujaca liczbe magow wody
        /// </summary>
        int counterWaterMage = 0;
        /// <summary>
        /// Zmienna przechowujaca liczbe magow wody
        /// </summary>
        int counterNecromancyMage = 0;
        /// <summary>
        /// Zmienna przechowujaca nazwe postaci w nowym oknie
        /// </summary>
        string heroNameNew;
        /// <summary>
        /// Zmienne przechowujace bonusy postaci w nowym oknie
        /// </summary>
        int bonusNew1;
        int bonusNew2;
        /// <summary>
        /// Tworzenie obiektow rnd i rnd1 na bazie klasy Random
        /// </summary>
        Random rnd = new Random();
        Random rnd1 = new Random();
        /// <summary>
        /// Zmienne przechowujace wartosci losowe z przedzialu czasowego
        /// </summary>
        int negativeEvent1;
        int positiveEvent1;
        #endregion
        public FormNew(Image image, string heroName, int bonus1, int bonus2)
        {
            InitializeComponent();
            //przypisanie zdjecia podczas wywolywania konstruktora z glownego okna do stworzonej zmiennej z nowego okna
            selectedHeroImage = image;
            //przypisanie wybranego zdjęcia z glownego okna do pictureBoxa z nowego okna
            pictureBoxSelectedHero.Image = selectedHeroImage;
            //przypisanie nazwy postaci z glownego okna do nowej zmiennej podczas wywolywania konstruktora 
            heroNameNew = heroName;
            //przypisanie bonusow z glownego okna do nowych zmiennych podczas wywolywania konstruktora 
            bonusNew1 = bonus1;
            bonusNew2 = bonus2;
            //instrukcja warunkowa sprawdzajaca poczatkowe bonusy postaci, jesli dana postac jest wybrana dodaj poczatkowe bonusy do okreslonych zasobow/jednostek
            if (heroName == "Diego")
            {
                //dodanie poczatkowych bonusow do zmiennych counterMagicOre i counterDigger
                counterMagicOre = counterMagicOre + bonusNew1;
                counterDigger = counterDigger + bonusNew2;
                //odswiezanie zawartosci textBoxMagicOreCounter i textBoxDiggerCounter
                textBoxMagicOreCounter.Text = counterMagicOre.ToString();
                textBoxDiggerCounter.Text = counterDigger.ToString();
            }
            else if (heroName == "Milten")
            {
                //dodanie poczatkowych bonusow do zmiennych counterFireRune i counterFireMage
                counterFireRune = counterFireRune + bonusNew1;
                counterFireMage = counterFireMage + bonusNew2;
                //odswiezanie zawartosci textBoxFireRuneCounter i textBoxMageFireCounter
                textBoxFireRuneCounter.Text = counterFireRune.ToString();
                textBoxMageFireCounter.Text = counterFireMage.ToString();
            }
            else if (heroName == "Gorn")
            {
                //dodanie poczatkowych bonusow do zmiennych counterWaterRune i counterGuard
                counterWaterRune = counterWaterRune + bonusNew1;
                counterGuard = counterGuard + bonusNew2;
                //odswiezanie zawartosci textBoxWaterRuneCounter i textBoxGuardCounter
                textBoxWaterRuneCounter.Text = counterWaterRune.ToString();
                textBoxGuardCounter.Text = counterGuard.ToString();
            }
            else
            {
                //dodanie poczatkowych bonusow do zmiennych counterMagicOre i counterDigger
                counterRunicStone = counterRunicStone + bonusNew1;
                counterAlchemist = counterAlchemist + bonusNew2;
                //odswiezanie zawartosci textBoxMagicOreCounter i textBoxDiggerCounter
                textBoxRunicStoneCounter.Text = counterRunicStone.ToString();
                textBoxAlchemistCounter.Text = counterAlchemist.ToString();
            }
            //przypisanie wartosci losowej z przedzialu od 60 do 99 do zmiennej negativeEvent1
            negativeEvent1 = rnd.Next(60, 100);

            //przypisanie wartosci losowej z przedzialu od 130 do 179 do zmiennej positiveEvent1
            positiveEvent1 = rnd1.Next(130, 180);
        }
        /// <summary>
        /// Funkcja wywolywana podczas wczytywania okienka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormNew_Load(object sender, EventArgs e)
        {
            //uruchomienie zegara
            timerCounter.Start();
        }
        /// <summary>
        /// wywolanie funkcji obslugiwanej przez watek elementu timerCounter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerCounter_Tick(object sender, EventArgs e)
        {
            //zwiekszenie zmmiennej counter
            counter++;
            //odswiezanie zawartosci labelTimeCounter
            labelTimeCounter.Text = counter.ToString();
            //kopacz
            //wykonuj instrukcje w warunku if jesli reszta z dzielenia wartosci zmiennej counter przez 5 jest rowna 0 (co 5 sekund)
            if (counter % 5 == 0)
            {
                //parsowanie elementu tekstowego textBoxMagicOreCounter na liczbę i przypisanie do zmiennej przechowujacej liczbe brylek rudy (counterMagicOre)
                counterMagicOre = Int32.Parse(textBoxMagicOreCounter.Text);
                //dodanie do calkowitej liczby brylek rudy, 5 brylek za kazdego zakupionego kopacza
                counterMagicOre = counterMagicOre + 5 * counterDigger;
                //odswiezanie zawartosci textBoxMagicOreCounter
                textBoxMagicOreCounter.Text = counterMagicOre.ToString();
            }
            //alchemik
            //wykonuj instrukcje w warunku if jesli reszta z dzielenia wartosci zmiennej counter przez 20 jest rowna 0 (co 20 sekund)
            if (counter % 20 == 0)
            {
                //parsowanie elementu tekstowego textBoxRunicStoneCounter na liczbę i przypisanie do zmiennej przechowujacej liczbe kamieni runicznych (counterRunicStone)
                counterRunicStone = Int32.Parse(textBoxRunicStoneCounter.Text);
                //dodanie do calkowitej liczby kamieni runicznych, 1 kamienia runicznego za kazdego zakupionego alchemika
                counterRunicStone = counterRunicStone + counterAlchemist;
                //odswiezanie zawartosci textBoxRunicStoneCounter
                textBoxRunicStoneCounter.Text = counterRunicStone.ToString();
            }
            //zdarzenia negatywne 1
            //sprawdzenie czy reszta z dzielenia zmiennej counter przez 100 (odpowiedzialnej za czas) jest rowna wartosci zmiennej negativeEvent (zmiennej losowej z przedzialu <60, 99>)
            if (counter % 100 == negativeEvent1)
            {
                //przypisywanie kolejnej wartosci losowej z przedzialu od 0 do 98 do zmiennej negativeEvent1
                negativeEvent1 = rnd.Next(0, 99);
                {
                    //sprawdzenie czy wartosc zmiennej counterGuard (liczba straznikow) jest wieksza badz rowna 8
                    if (counterGuard >= 8)
                    {
                        //pokazywanie wiadomosci
                        MessageBox.Show("Twoich kopaczy napadło stado pełzaczy. Na szczęście liczba strażników była wystarczająca by pokonać te cholorene bestie. Twoi kopacze zostali uratowani!!!");
                    }
                    else
                    {
                        //pokazywanie wiadomosci
                        MessageBox.Show("Twoich kopaczy napadło stado pełzaczy. Niestety liczba strażników była za mała by pokonać te cholorene bestie. Tracisz swoich wszystkich strażników i kopaczy");
                        //zerowanie zmiennych counterDigger i counterGuard
                        counterDigger = 0;
                        counterGuard = 0;
                        //odswiezanie wartosci dla elementow textBoxDiggerCounter i textBoxGuardCounter
                        textBoxDiggerCounter.Text = counterDigger.ToString();
                        textBoxGuardCounter.Text = counterGuard.ToString();
                    }
                }
            }
            //zdarzenie negatywne 2
            //sprawdzenie czy reszta z dzielenia wartosci przez 150 dla zmiennej counter jest rowna 0 i czy wartosc zmiennej counterGuard (liczba straznikow) jest wieksza badz rowna 5 i czy wartosc zmiennej counterDigger (liczba kopaczy) jest wieksza badz rowna 5 
            if (counter % 150 == 0 && counterGuard >= 5 && counterDigger >= 5)
            {
                //sprawdzenie czy wartosc zmiennej counterGuard (liczba straznikow) jest wieksza badz rowna 12
                if (counterGuard >= 12)
                {
                    //pokazywanie wiadomosci
                    MessageBox.Show("Twoją grupę kopaczy wraz ze strażnikami w trakcie drogi z obozu do kopalni napadło stado zębaczy. Na szczęście liczba strażników była wystarczająca by pokonać te cholorene bestie. Twoi kopacze zostali uratowani!!!");
                }
                else
                {
                    //pokazywanie wiadomosci
                    MessageBox.Show("Twoją grupę kopaczy wraz ze strażnikami w trakcie drogi z obozu do kopalni napadło stado zębaczy. Niestety liczba strażników była za mała by pokonać te cholorene bestie. Tracisz 5 strażników i 5 kopaczy");
                    //odejmowanie wartosci 5 od zmiennych counterDigger i counterGuard
                    counterDigger = counterDigger - 5;
                    counterGuard = counterGuard - 5;
                    //odswiezanie wartosci dla elementow textBoxDiggerCounter i textBoxGuardCounter 
                    textBoxDiggerCounter.Text = counterDigger.ToString();
                    textBoxGuardCounter.Text = counterGuard.ToString();
                }
            }
            //zdarzenie negatywne 3
            //sprawdzenie czy reszta z dzielenia wartosci przez 40 dla zmiennej counter jest rowna 0 i czy wartosc zmiennej counterAlchemist (liczba alchemikow) jest wieksza od 3
            if (counter % 40 == 0 && counterAlchemist > 3)
            {
                //pokazywanie wiadomosci
                MessageBox.Show("3 twoich alchemików wyruszyło poza obóz w poszukiwaniu ziół leczniczych. Niestety wtargnęli przypadkiem na teren orków i zostali zabici.");
                //odejmowanie wartosci 3 od zmiennej counterAlchemist
                counterAlchemist = counterAlchemist - 3;
                //odswiezanie wartosci dla elementu textBoxAlchemistCounter
                textBoxAlchemistCounter.Text = counterAlchemist.ToString();
            }
            //zdarzenie negatywne 4
            //sprawdzenie czy reszta z dzielenia wartosci przez 320 dla zmiennej counter jest rowna 0 i czy wartosc zmiennej counterFireRune i counterWaterRune jest wieksza od 3 i czy wartosc counterFireMage lub counterWaterMage jest wieksza od 3
            if (counter % 320 == 0 && counterFireRune > 3 & counterWaterRune > 3 && (counterFireMage > 3 || counterWaterMage > 3))
            {
                MessageBox.Show("Twoi magowie zostali napadnięci przez gobliny podczas przeszukiwania grobowców. Musieli wykorzystać 1 runę ognia i 1 runę wody by przepędzić gobliny. W związku z czym tracisz po jednej runie ognia i wody.");
                //odejmowanie wartosci 1 od zmiennych counterFireRune i counterWaterRune
                counterFireRune = counterFireRune - 1;
                counterWaterRune = counterWaterRune - 1;
                //odswiezanie wartosci dla elementow textBoxFireRuneCounter i textBoxWaterRuneCounter
                textBoxFireRuneCounter.Text = counterFireRune.ToString();
                textBoxWaterRuneCounter.Text = counterWaterRune.ToString();
            }
            //zdarzenie pozytywne 1
            //sprawdzenie czy reszta z dzielenia zmiennej counter przez 180 (odpowiedzialnej za czas) jest rowna wartosci zmiennej positiveEvent1 (zmiennej losowej z przedzialu <130, 179>)
            if (counter % 180 == positiveEvent1)
            {
                //przypisywanie kolejnej wartosci losowej z przedzialu od 100 do 179 do zmiennej positiveEvent1
                positiveEvent1 = rnd1.Next(100, 180);
                //pokazywanie wiadomosci
                MessageBox.Show("Twoi kopacze dostali się do nieodkrytych wcześniej złóż bryłek rudy. Otrzymujesz 400 bryłek rudy");
                //dodanie wartosci 400 do zmiennej counterMagicOre
                counterMagicOre = counterMagicOre + 400;
                //odswiezanie wartosci dla elementu textBoxMagicOreCounter
                textBoxMagicOreCounter.Text = counterMagicOre.ToString();
            }
            //zdarzenie pozytywne 2
            //sprawdzenie czy reszta z dzielenia zmiennej counter przez 130 jest rowna 0 i zmienne counterFire i counterWaterMage sa wieksze od 2
            if (counter % 135 == 0 & (counterFireMage > 2 || counterWaterMage > 2))
            {
                //pokazywanie wiadomosci
                MessageBox.Show("Twoi magowie znelezli w podziemnych kryptach cenne skarby!!!");
                //dodawanie wartosci 1 do zmiennych counterFireRune i counterWaterRune
                counterFireRune = counterFireRune + 1;
                counterWaterRune = counterWaterRune + 1;
                //dodawanie wartosci 250 do zmiennej counterMagicOre
                counterMagicOre = counterMagicOre + 250;
                //odswiezanie elementow textBoxMagicOreCounter, textBoxFireRuneCounter i textBoxWaterRuneCounter
                textBoxMagicOreCounter.Text = counterMagicOre.ToString();
                textBoxFireRuneCounter.Text = counterFireRune.ToString();
                textBoxWaterRuneCounter.Text = counterWaterRune.ToString();
            }
        }
        /// <summary>
        /// Przycisk zwiekszajacy zawartosc textBoxDiggerCounter (liczby kopaczy)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyDigger_Click(object sender, EventArgs e)
        {
            //parsowanie elementu tekstowego textBoxMagicOreCounter na liczbę i przypisanie do zmiennej przechowujacej liczbe brylek rudy (counterMagicOre)
            counterMagicOre = Int32.Parse(textBoxMagicOreCounter.Text);
            if(counterMagicOre >= 50)
            {
                //odejmowanie 50 brylek rudy za kazdym kliknieciem przycisku odpowiedzialnego za zakup kopacza
                counterMagicOre = counterMagicOre - 50;
                //odswiezanie zawartosci textBoxMagicOreCounter
                textBoxMagicOreCounter.Text = counterMagicOre.ToString();
                //inkrementacja wartosci dla zmiennej przechowujacej liczbe kopaczy (counterDigger)
                counterDigger++;
                //odswiezanie zawartosci textBoxDiggerCounter
                textBoxDiggerCounter.Text = counterDigger.ToString();
            }
            else
            {
                MessageBox.Show("Nie masz wystarczającej liczby bryłek rudy aby zakupić kopacza!");
            }
        }
        /// <summary>
        /// Przycisk zwiekszajacy zawartosc textBoxAlchemistCounter (liczby alechemikow)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyAlchemist_Click(object sender, EventArgs e)
        {
            //parsowanie elementu tekstowego textBoxMagicOreCounter na liczbę i przypisanie do zmiennej przechowujacej liczbe brylek rudy (counterMagicOre)
            counterMagicOre = Int32.Parse(textBoxMagicOreCounter.Text);
            //wykonuj instrukcje tylko gdy liczba brylek rudy jest wieksza badz rowna 70
            if (counterMagicOre >= 70)
            {
                //odejmowanie 70 brylek rudy za kazdym kliknieciem przycisku odpowiedzialnego za zakup alchemika
                counterMagicOre = counterMagicOre - 70;
                //odswiezanie zawartosci textBoxMagicOreCounter
                textBoxMagicOreCounter.Text = counterMagicOre.ToString();
                //inkrementacja wartosci dla zmiennej przechowujacej liczbe alchemikow (counterAlchemist)
                counterAlchemist++;
                //odswiezanie zawartosci textBoxAlchemistCounter
                textBoxAlchemistCounter.Text = counterAlchemist.ToString();
            }
            else
            {
                //jesli warunek nie jest spelniony pokazuj wiadomosc
                MessageBox.Show("Nie masz wystarczającej liczby bryłek rudy aby zakupić alchemika!");
            }
        }
        /// <summary>
        /// Przycisk zwiekszajacy zawartosc textBoxGuardCounter (liczby straznikow)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyGuard_Click(object sender, EventArgs e)
        {
            //parsowanie elementu tekstowego textBoxMagicOreCounter na liczbę i przypisanie do zmiennej przechowujacej liczbe brylek rudy (counterMagicOre)
            counterMagicOre = Int32.Parse(textBoxMagicOreCounter.Text);
            //wykonuj instrukcje tylko gdy liczba brylek rudy jest wieksza badz rowna 100
            if (counterMagicOre >= 100)
            {
                //odejmowanie 100 brylek rudy za kazdym kliknieciem przycisku odpowiedzialnego za zakup straznika
                counterMagicOre = counterMagicOre - 100;
                //odswiezanie zawartosci textBoxMagicOreCounter
                textBoxMagicOreCounter.Text = counterMagicOre.ToString();
                //inkrementacja wartosci dla zmiennej przechowujacej liczbe straznikow (counterGuard)
                counterGuard++;
                //odswiezanie zawartosci textBoxGuardCounter
                textBoxGuardCounter.Text = counterGuard.ToString();
            }
            else
            {
                //jesli warunek nie jest spelniony pokazuj wiadomosc
                MessageBox.Show("Nie masz wystarczającej liczby bryłek rudy aby zakupić strażnika!");
            }
        }
        /// <summary>
        /// Przycisk zwiekszajacy zawartosc textBoxFireRuneCounter (liczby run ognia)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyFireRune_Click(object sender, EventArgs e)
        {
            //parsowanie elementu tekstowego textBoxRunicStoneCounter na liczbę i przypisanie do zmiennej przechowujacej liczbe kamieni runicznych (counterRunicStone)
            counterRunicStone = Int32.Parse(textBoxRunicStoneCounter.Text);
            //wykonuj instrukcje tylko gdy liczba kamieni runicznych jest wieksza badz rowna 3
            if (counterRunicStone >= 3)
            {
                //odejmowanie 3 kamieni runicznych za kazdym kliknieciem przycisku odpowiedzialnego za zakup runy ognia
                counterRunicStone = counterRunicStone - 3;
                //odswiezanie zawartosci textBoxRunicStoneCounter
                textBoxRunicStoneCounter.Text = counterRunicStone.ToString();
                //inkrementacja wartosci dla zmiennej przechowujacej liczbe run ognia (counterFireRune)
                counterFireRune++;
                //odswiezanie zawartosci textBoxFireRuneCounter
                textBoxFireRuneCounter.Text = counterFireRune.ToString();
            }
            else
            {
                //jesli warunek nie jest spelniony pokazuj wiadomosc
                MessageBox.Show("Nie masz wystarczającej liczby kamieni runicznych aby zakupić runę ognia!");
            }
        }
        /// <summary>
        ///  Przycisk zwiekszajacy zawartosc textBoxWaterRuneCounter (liczby run wody)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyWaterRune_Click(object sender, EventArgs e)
        {
            //parsowanie elementu tekstowego textBoxRunicStoneCounter na liczbę i przypisanie do zmiennej przechowujacej liczbe kamieni runicznych (counterRunicStone)
            counterRunicStone = Int32.Parse(textBoxRunicStoneCounter.Text);
            //wykonuj instrukcje tylko gdy liczba kamieni runicznych jest wieksza badz rowna 3
            if (counterRunicStone >= 3)
            {
                //odejmowanie 3 kamieni runicznych za kazdym kliknieciem przycisku odpowiedzialnego za zakup runy wody
                counterRunicStone = counterRunicStone - 3;
                //odswiezanie zawartosci textBoxRunicStoneCounter
                textBoxRunicStoneCounter.Text = counterRunicStone.ToString();
                //inkrementacja wartosci dla zmiennej przechowujacej liczbe run wody (counterWaterRune)
                counterWaterRune++;
                //odswiezanie zawartosci textBoxWaterRuneCounter
                textBoxWaterRuneCounter.Text = counterWaterRune.ToString();
            }
            else
            {
                //jesli warunek nie jest spelniony pokazuj wiadomosc
                MessageBox.Show("Nie masz wystarczającej liczby kamieni runicznych aby zakupić runę wody!");
            }
        }
        /// <summary>
        /// Przycisk zwiekszajacy zawartosc textBoxNecromancyRuneCounter (liczby run nekromancji)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyNecromancyRune_Click(object sender, EventArgs e)
        {
            //parsowanie elementu tekstowego textBoxRunicStoneCounter na liczbę i przypisanie do zmiennej przechowujacej liczbe kamieni runicznych (counterRunicStone)
            counterRunicStone = Int32.Parse(textBoxRunicStoneCounter.Text);
            //wykonuj instrukcje tylko gdy liczba kamieni runicznych jest wieksza badz rowna 3
            if (counterRunicStone >= 3)
            {
                //odejmowanie 3 kamieni runicznych za kazdym kliknieciem przycisku odpowiedzialnego za zakup runy nekromancji
                counterRunicStone = counterRunicStone - 3;
                //odswiezanie zawartosci textBoxRunicStoneCounter
                textBoxRunicStoneCounter.Text = counterRunicStone.ToString();
                //inkrementacja wartosci dla zmiennej przechowujacej liczbe run nekromancji (counterNecromancyRune)
                counterNecromancyRune++;
                //odswiezanie zawartosci textBoxNecromancyRuneCounter
                textBoxNecromancyRuneCounter.Text = counterNecromancyRune.ToString();
            }
            else
            {
                //jesli warunek nie jest spelniony pokazuj wiadomosc
                MessageBox.Show("Nie masz wystarczającej liczby kamieni runicznych aby zakupić runę nekromancji!");
            }
        }
        /// <summary>
        /// Przycisk zwiekszajacy zawartosc textBoxMageFireCounter (liczby magow ognia)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyMageFire_Click(object sender, EventArgs e)
        {
            //parsowanie elementu tekstowego textBoxMagicOreCounter na liczbę i przypisanie do zmiennej przechowujacej liczbe brylek rudy (counterMagicOre)
            counterMagicOre = Int32.Parse(textBoxMagicOreCounter.Text);
            //parsowanie elementu tekstowego textBoxFireRuneCounter na liczbę i przypisanie do zmiennej przechowujacej liczbe run ognia (counterFireRune)
            counterFireRune = Int32.Parse(textBoxFireRuneCounter.Text);

            //wykonuj instrukcje tylko gdy liczba brylek rudy jest wieksza badz rowna 100 i liczba run ognia wieksza badz rowna 1
            if (counterMagicOre >= 100 && counterFireRune >= 1)
            {
                //odejmowanie 100 brylek rudy za kazdym kliknieciem przycisku odpowiedzialnego za zakup maga ognia
                counterMagicOre = counterMagicOre - 100;
                //odejmowanie 1 runy ognia za kazdym kliknieciem przycisku odpowiedzialnego za zakup maga ognia
                counterFireRune = counterFireRune - 1;
                //odswiezanie zawartosci textBoxMagicOreCounter
                textBoxMagicOreCounter.Text = counterMagicOre.ToString();
                //odswiezanie zawartosci textBoxFireRuneCounter
                textBoxFireRuneCounter.Text = counterFireRune.ToString();
                //inkrementacja wartosci dla zmiennej przechowujacej liczbe magow ognia (counterFireMage)
                counterFireMage++;
                //odswiezanie zawartosci textBoxGuardCounter
                textBoxMageFireCounter.Text = counterFireMage.ToString();
            }
            else if(counterMagicOre < 100 && counterFireRune >= 1)
            {
                //jesli masz za malo brylek rudy pokazuj wiadomosc
                MessageBox.Show("Nie masz wystarczającej liczby bryłek rudy aby zakupić maga ognia!");
            }
            else if(counterMagicOre >= 100 && counterFireRune < 1)
            {
                //jesli masz za malo run ognia pokazuj wiadomosc
                MessageBox.Show("Nie masz wystarczającej liczby run ognia aby zakupić maga ognia!");
            }
            else
            {
                //jesli masz za malo brylek rudy i run ognia pokazuj wiadomosc
                MessageBox.Show("Nie masz wystarczającej liczby bryłek rudy i run ognia aby zakupić maga ognia!");
            }
        }
        /// <summary>
        /// Przycisk zwiekszajacy zawartosc textBoxMageWaterCounter (liczby magow wody)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyMageWater_Click(object sender, EventArgs e)
        {
            //parsowanie elementu tekstowego textBoxMagicOreCounter na liczbę i przypisanie do zmiennej przechowujacej liczbe brylek rudy (counterMagicOre)
            counterMagicOre = Int32.Parse(textBoxMagicOreCounter.Text);
            //parsowanie elementu tekstowego textBoxWaterRuneCounter na liczbę i przypisanie do zmiennej przechowujacej liczbe run wody (counterWaterRune)
            counterWaterRune = Int32.Parse(textBoxWaterRuneCounter.Text);

            //wykonuj instrukcje tylko gdy liczba brylek rudy jest wieksza badz rowna 100 i liczba run wody wieksza badz rowna 1
            if (counterMagicOre >= 100 && counterWaterRune >= 1)
            {
                //odejmowanie 100 brylek rudy za kazdym kliknieciem przycisku odpowiedzialnego za zakup maga wody
                counterMagicOre = counterMagicOre - 100;
                //odejmowanie 1 runy ognia za kazdym kliknieciem przycisku odpowiedzialnego za zakup maga ognia
                counterWaterRune = counterWaterRune - 1;
                //odswiezanie zawartosci textBoxMagicOreCounter
                textBoxMagicOreCounter.Text = counterMagicOre.ToString();
                //odswiezanie zawartosci textBoxWaterRuneCounter
                textBoxWaterRuneCounter.Text = counterWaterRune.ToString();
                //inkrementacja wartosci dla zmiennej przechowujacej liczbe magow wody (counterWaterMage)
                counterWaterMage++;
                //odswiezanie zawartosci textBoxGuardCounter
                textBoxMageWaterCounter.Text = counterWaterMage.ToString();
            }
            else if (counterMagicOre < 100 && counterWaterRune >= 1)
            {
                //jesli masz za malo brylek rudy pokazuj wiadomosc
                MessageBox.Show("Nie masz wystarczającej liczby bryłek rudy aby zakupić maga wody!");
            }
            else if (counterMagicOre >= 100 && counterWaterRune < 1)
            {
                //jesli masz za malo run wody pokazuj wiadomosc
                MessageBox.Show("Nie masz wystarczającej liczby run wody aby zakupić maga wody!");
            }
            else
            {
                //jesli masz za malo brylek rudy i run wody pokazuj wiadomosc
                MessageBox.Show("Nie masz wystarczającej liczby bryłek rudy i run wody aby zakupić maga wody!");
            }
        }
        /// <summary>
        ///  Przycisk zwiekszajacy zawartosc textBoxNecromancerCounter (liczby run nekromancji)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyNecromancer_Click(object sender, EventArgs e)
        {
            //parsowanie elementu tekstowego textBoxMagicOreCounter na liczbę i przypisanie do zmiennej przechowujacej liczbe brylek rudy (counterMagicOre)
            counterMagicOre = Int32.Parse(textBoxMagicOreCounter.Text);
            //parsowanie elementu tekstowego textBoxNecromancyRuneCounter na liczbę i przypisanie do zmiennej przechowujacej liczbe run nekromancji (counterNecromancyRune)
            counterNecromancyRune = Int32.Parse(textBoxNecromancyRuneCounter.Text);

            //wykonuj instrukcje tylko gdy liczba brylek rudy jest wieksza badz rowna 200 i liczba run nekromacji wieksza badz rowna 5
            if (counterMagicOre >= 200 && counterNecromancyRune >= 5)
            {
                //odejmowanie 200 brylek rudy za kazdym kliknieciem przycisku odpowiedzialnego za zakup nekromanty
                counterMagicOre = counterMagicOre - 200;
                //odejmowanie 5 run nekromancji za kazdym kliknieciem przycisku odpowiedzialnego za zakup nekromanty
                counterNecromancyRune = counterNecromancyRune - 5;
                //odswiezanie zawartosci textBoxMagicOreCounter
                textBoxMagicOreCounter.Text = counterMagicOre.ToString();
                //odswiezanie zawartosci textBoxNecromancyRuneCounter
                textBoxNecromancyRuneCounter.Text = counterNecromancyRune.ToString();
                //inkrementacja wartosci dla zmiennej przechowujacej liczbe magow wody (counterWaterMage)
                counterNecromancyMage++;
                //odswiezanie zawartosci textBoxGuardCounter
                textBoxNecromancerCounter.Text = counterNecromancyMage.ToString();
            }
            else if (counterMagicOre < 200 && counterNecromancyRune >= 5)
            {
                //jesli masz za malo brylek rudy pokazuj wiadomosc
                MessageBox.Show("Nie masz wystarczającej liczby bryłek rudy aby zakupić nekromantę!");
            }
            else if (counterMagicOre >= 200 && counterNecromancyRune < 5)
            {
                //jesli masz za malo run nekromancji pokazuj wiadomosc
                MessageBox.Show("Nie masz wystarczającej liczby run nekromancji aby zakupić nekromantę!");
            }
            else
            {
                //jesli masz za malo brylek rudy i run nekromancji pokazuj wiadomosc
                MessageBox.Show("Nie masz wystarczającej liczby bryłek rudy i run nekromancji aby zakupić nekromantę!");
            }
        }
        /// <summary>
        /// Przycisk konczacy gre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDefeatMagicBarrier_Click(object sender, EventArgs e)
        {
            /*sprawdzenie czy wartosc zmiennej counterMagicOre jest wieksza badz rowna 5000 i czy wartosc zmiennej counterFireMage i counterWaterMage jest wieksza badz rowna 6
            i czy wartosc zmiennej counterNecromancyMage jest wieksza badz rowna 1*/
            if (counterMagicOre >= 5000 && counterFireMage >=6 && counterWaterMage >=6 && counterNecromancyMage >=1)
            {
                //pokazywanie wiadomosci
                MessageBox.Show("Hurra!!! Ty i twoi ludzie wydostaliście się z Górniczej Doliny!!! Zgromadzona ilość rudy i rytuał przeprowadzony przez magów umożliwił wysadzenie magicznej bariery!!! Misja zakończona sukcesem!!! Ukończyłeś grę!!!");
                //zamkniecie okna
                this.Hide();
            }
            else
            {
                //pokazywanie wiadomosci
                MessageBox.Show("Nie masz wystarczającej liczby bryłek rudy lub liczby magów żeby zrealizować rytuał zniszczenia magicznej bariery. Kontynuuj grę. Niech Innos ma Cię w swojej Opiece!!!");
            }
        }
    }
}
