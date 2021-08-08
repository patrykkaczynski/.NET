using PatrykKaczynskiZadDom2.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatrykKaczynskiZadDom2
{
    /// <summary>
    /// Klasa okna głównego aplikacji
    /// </summary>
    public partial class FormMain : Form
    {
        private readonly Repository _repository = new Repository();

        /// <summary>
        /// Kosntruktor okna głównego aplikacji
        /// </summary>
        public FormMain()
        {
            //Ustawienie okna, żeby pojawiało się na środku ekranu
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //Aktualizacja danych w dataGridViewPokemons podczas ładowania okna
            RefreshDataGridViewPokemons();

            //Dostosowanie tabeli dataGridViewPokemons podczas ładowania okna
            CustomizeDataGridViewPokemons();

        }

        /// <summary>
        /// Metoda wykonywana za każdym razem gdy użytkownik zmieni zaznaczenie wiersza w dataGridViewPokemons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewPokemons_SelectionChanged(object sender, EventArgs e)
        {
            //Jeśli żadnen wiersz nie jest zaznaczony lub jest zaznaczonych więcej niż jeden to nic nie rób (return)
            int rowsCount = dataGridViewPokemons.SelectedRows.Count;
            if (rowsCount == 0 || rowsCount > 1)
                return;

            //Wzięcie pierwszego zaznaczonego wiersza
            DataGridViewRow row = dataGridViewPokemons.SelectedRows[0];

            //Wyciągniecie danych z zaznaczonego wiersza
            //Image image = image(row.Cells[1].Value.ToString());
            int id = int.Parse(row.Cells[0].Value.ToString());
            string name = row.Cells[2].Value.ToString();
            string firstTypeName = row.Cells[3].Value.ToString();
            string secondTypeName = row.Cells[4].Value.ToString();
            string occurrenceName = row.Cells[5].Value.ToString();
            string firstAbilityName = row.Cells[6].Value.ToString();
            string secondAbilityName = row.Cells[7].Value.ToString();
            string hiddenAbilityName = row.Cells[8].Value.ToString();
            int hp = int.Parse(row.Cells[9].Value.ToString());
            int attack = int.Parse(row.Cells[10].Value.ToString());
            int defence = int.Parse(row.Cells[11].Value.ToString());
            int specialAttack = int.Parse(row.Cells[12].Value.ToString());
            int specialDefence = int.Parse(row.Cells[13].Value.ToString());
            int speed = int.Parse(row.Cells[14].Value.ToString());
            int sum = hp + attack + defence + specialAttack + specialDefence + speed;
            string sex = row.Cells[16].Value.ToString();

            //Ustawianie danych w textboxach wybranego pokemona
            textBoxId.Text = id.ToString();
            textBoxName.Text = name;
            comboBoxFirstType.Text = firstTypeName;
            comboBoxSecondType.Text = secondTypeName;
            comboBoxOccurrence.Text = occurrenceName;
            comboBoxFirstAbility.Text = firstAbilityName;
            comboBoxSecondAbility.Text = secondAbilityName;
            comboBoxHiddenAbility.Text = hiddenAbilityName;
            textBoxHP.Text = hp.ToString();
            textBoxAttack.Text = attack.ToString();
            textBoxDefence.Text = defence.ToString();
            textBoxSpecialAttack.Text = specialAttack.ToString();
            textBoxSpecialDefence.Text = specialDefence.ToString();
            textBoxSpeed.Text = speed.ToString();
            textBoxSum.Text = sum.ToString();
            comboBoxSex.Text = sex.ToString();
            labelAction.Text = "Wybrano pokemona";
        }
        /// <summary>
        /// Metoda dostosowująca dataGridViewPokemons - ustawianie nazw kolumn
        /// </summary>
        private void CustomizeDataGridViewPokemons()
        {
            //Ustawienie nazwy kolumn na język polski
            dataGridViewPokemons.Columns["Name"].HeaderText = "Nazwa";
            dataGridViewPokemons.Columns["ImageFile"].HeaderText = "Wygląd";
            dataGridViewPokemons.Columns["FirstTypeName"].HeaderText = "Typ #1";
            dataGridViewPokemons.Columns["SecondTypeName"].HeaderText = "Typ #2";
            dataGridViewPokemons.Columns["Occurrence"].HeaderText = "Występowanie";
            dataGridViewPokemons.Columns["FirstAbilityName"].HeaderText = "Pierwsza zdolność";
            dataGridViewPokemons.Columns["SecondAbilityName"].HeaderText = "Druga zdolność";
            dataGridViewPokemons.Columns["HiddenAbilityName"].HeaderText = "Ukryta zdolność";
            dataGridViewPokemons.Columns["HiddenAbilityName"].HeaderText = "Ukryta zdolność";
            dataGridViewPokemons.Columns["HP"].HeaderText = "HP";
            dataGridViewPokemons.Columns["Attack"].HeaderText = "Atak";
            dataGridViewPokemons.Columns["Defence"].HeaderText = "Obrona";
            dataGridViewPokemons.Columns["SpecialAttack"].HeaderText = "Specjalny Atak";
            dataGridViewPokemons.Columns["SpecialDefence"].HeaderText = "Specjalna Obrona";
            dataGridViewPokemons.Columns["Speed"].HeaderText = "Szybkość";
            dataGridViewPokemons.Columns["Sum"].HeaderText = "Suma";
            dataGridViewPokemons.Columns["SexName"].HeaderText = "Płeć";
        }

        /// <summary>
        /// Metoda czyszcząca wszystkie TextBoxy w oknie głównym
        /// </summary>
        private void ClearTextBoxes()
        {
            textBoxId.Text = "";
            textBoxName.Text = "";
            comboBoxFirstType.Text = "";
            comboBoxSecondType.Text = "";
            comboBoxOccurrence.Text = "";
            comboBoxFirstAbility.Text = "";
            comboBoxSecondAbility.Text = "";
            comboBoxHiddenAbility.Text = "";
            textBoxHP.Text = "0";
            textBoxAttack.Text = "0";
            textBoxDefence.Text = "0";
            textBoxSpecialAttack.Text = "0";
            textBoxSpecialDefence.Text = "0";
            textBoxSpeed.Text = "0";
            textBoxSum.Text = "0";
            comboBoxSex.Text = "";
        }

        /// <summary>
        /// Metoda odświeżająca dane w dataGridViewPokemons
        /// </summary>
        private void RefreshDataGridViewPokemons()
        {
            //Pobranie wszystkich pokemonów z bazy danych
            DataTable pokemons = _repository.GetPokemons();

            //Przypisanie wszystkich pokemonów do datagridViewPokemons
            dataGridViewPokemons.DataSource = pokemons;
        }

        /// <summary>
        /// Metoda wywoływana po naciśnięciu przycisku do dodawania nowego pokemona
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddPokemon_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string firstTypeName = comboBoxFirstType.Text;
            string secondTypeName = comboBoxSecondType.Text;
            string occurrenceName = comboBoxOccurrence.Text;
            string firstAbilityName = comboBoxFirstAbility.Text;
            string secondAbilityName = comboBoxSecondAbility.Text;
            string hiddenAbilityName = comboBoxHiddenAbility.Text;
            int hp = int.Parse(textBoxHP.Text);
            int attack = int.Parse(textBoxAttack.Text);
            int defence = int.Parse(textBoxDefence.Text);
            int specialAttack = int.Parse(textBoxSpecialAttack.Text);
            int specialDefence = int.Parse(textBoxSpecialDefence.Text);
            int speed = int.Parse(textBoxSpeed.Text);
            int sum = hp + attack + defence + specialAttack + specialDefence + speed;
            string sexName = comboBoxSex.Text;

            _repository.AddPokemon(name, hp, attack, defence, specialAttack, specialDefence, speed, sum, firstTypeName, secondTypeName, occurrenceName, firstAbilityName, secondAbilityName, hiddenAbilityName, sexName);

            RefreshDataGridViewPokemons();
            ClearTextBoxes();
            labelAction.Text = "Dodano pokemona";
        }

        /// <summary>
        /// Metoda wywoływana po naciśnięciu przycisku od edycji pokemona
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditPokemon_Click(object sender, EventArgs e)
        {
            //Wyciągnięcie danych z textboxów
            int id = int.Parse(textBoxId.Text);
            string name = textBoxName.Text;
            string firstTypeName = comboBoxFirstType.Text;
            string secondTypeName = comboBoxSecondType.Text;
            string occurrenceName = comboBoxOccurrence.Text;
            string firstAbilityName = comboBoxFirstAbility.Text;
            string secondAbilityName = comboBoxSecondAbility.Text;
            string hiddenAbilityName = comboBoxHiddenAbility.Text;
            int hp = int.Parse(textBoxHP.Text);
            int attack = int.Parse(textBoxAttack.Text);
            int defence = int.Parse(textBoxDefence.Text);
            int specialAttack = int.Parse(textBoxSpecialAttack.Text);
            int specialDefence = int.Parse(textBoxSpecialDefence.Text);
            int speed = int.Parse(textBoxSpeed.Text);
            int sum = hp + attack + defence + specialAttack + specialDefence + speed;
            string sexName = comboBoxSex.Text;

            //Aktualizacja pokemona
            _repository.EditPokemon(id, name, hp, attack, defence, specialAttack, specialDefence, speed, sum, firstTypeName, secondTypeName, occurrenceName, firstAbilityName, secondAbilityName, hiddenAbilityName, sexName);

            RefreshDataGridViewPokemons();
            ClearTextBoxes();
            labelAction.Text = "Edytowano pokemona";
        }

        /// <summary>
        /// Metoda wywoływana po naciśnięciu przycisku od czyszczenia TextBoxów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClearTextBoxes_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            labelAction.Text = "Wyczyszczono pola";
        }

        /// <summary>
        /// Metoda wywoływana po naciśnięciu przycisku do usuwania pokemona
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeletePokemon_Click(object sender, EventArgs e)
        {
            //Wyciągnięcie Id z textboxu
            int pokemonId = int.Parse(textBoxId.Text);

            //Usunięcie pokemona z bazy danych
            _repository.DeletePokemon(pokemonId);

            RefreshDataGridViewPokemons();
            ClearTextBoxes();
            labelAction.Text = "Usunięto pokemona";
        }

        /// <summary>
        /// Metoda aktualizująca wartość textBoxSum po zmianie wartości w textBoxHP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxHP_TextChanged(object sender, EventArgs e)
        {
            int sum = int.Parse(textBoxSum.Text);
            sum = sum + int.Parse(textBoxHP.Text);
            textBoxSum.Text = sum.ToString();
        }

        /// <summary>
        /// Metoda aktualizująca wartość textBoxSum po zmianie wartości w textBoxAttack
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxAttack_TextChanged(object sender, EventArgs e)
        {
            int sum = int.Parse(textBoxSum.Text);
            sum = sum + int.Parse(textBoxAttack.Text);
            textBoxSum.Text = sum.ToString();
        }

        /// <summary>
        /// Metoda aktualizująca wartość textBoxSum po zmianie wartości w textBoxDefence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxDefence_TextChanged(object sender, EventArgs e)
        {
            int sum = int.Parse(textBoxSum.Text);
            sum = sum + int.Parse(textBoxDefence.Text);
            textBoxSum.Text = sum.ToString();
        }

        /// <summary>
        /// Metoda aktualizująca wartość textBoxSum po zmianie wartości w textBoxSpecialAttack
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxSpecialAttack_TextChanged(object sender, EventArgs e)
        {
            int sum = int.Parse(textBoxSum.Text);
            sum = sum + int.Parse(textBoxSpecialAttack.Text);
            textBoxSum.Text = sum.ToString();
        }

        /// <summary>
        /// Metoda aktualizująca wartość textBoxSum po zmianie wartości w textBoxSpecialDefence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxSpecialDefence_TextChanged(object sender, EventArgs e)
        {
            int sum = int.Parse(textBoxSum.Text);
            sum = sum + int.Parse(textBoxSpecialDefence.Text);
            textBoxSum.Text = sum.ToString();
        }

        /// <summary>
        /// Metoda aktualizująca wartość textBoxSum po zmianie wartości w textBoxSpeed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxSpeed_TextChanged(object sender, EventArgs e)
        {
            int sum = int.Parse(textBoxSum.Text);
            sum = sum + int.Parse(textBoxSpeed.Text);
            textBoxSum.Text = sum.ToString();
        }
    }
}
