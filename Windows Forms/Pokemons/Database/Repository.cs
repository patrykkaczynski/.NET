using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatrykKaczynskiZadDom2.Database
{
    /// <summary>
    /// Klasa abstrakcyjna mająca zmienne i/lub metody, które każde repozytorium powinno zawierać
    /// </summary>
    class Repository
    {
        private readonly SqlConnection _connection = new SqlConnection(Properties.Resources.ConnectionString);

        /// <summary>
        /// Metoda zwracająca wszystkie pokemony z tabeli Pokemons
        /// </summary>
        /// <returns></returns>
        public DataTable GetPokemons()
        {
            string query = "SELECT Pokemons.Id, Pokemons.ImageFile, Pokemons.Name, FirstType.FirstTypeName, SecondType.SecondTypeName, Occurrence.Occurrence, FirstAbility.FirstAbilityName, SecondAbility.SecondAbilityName, HiddenAbility.HiddenAbilityName, Pokemons.HP, Pokemons.Attack, Pokemons.Defence, Pokemons.SpecialAttack, Pokemons.SpecialDefence, Pokemons.Speed, Pokemons.Sum, Sex.SexName FROM Pokemons JOIN FirstType ON Pokemons.FirstTypeId = FirstType.Id JOIN SecondType ON Pokemons.SecondTypeId = SecondType.Id JOIN Occurrence ON Pokemons.OccurrenceId = Occurrence.Id JOIN FirstAbility ON Pokemons.FirstAbilityId = FirstAbility.Id JOIN SecondAbility ON Pokemons.SecondAbilityId = SecondAbility.Id JOIN HiddenAbility ON Pokemons.HiddenAbilityId = HiddenAbility.Id JOIN Sex ON Pokemons.SexId = Sex.Id; ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, _connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        /// <summary>
        /// Metoda dodająca nowego pokemona do tabeli Pokemons
        /// </summary>
        /// <param name="name"></param>
        /// <param name="hp"></param>
        /// <param name="attack"></param>
        /// <param name="defence"></param>
        /// <param name="specialAttack"></param>
        /// <param name="specialDefence"></param>
        /// <param name="speed"></param>
        /// <param name="sum"></param>
        /// <param name="firstTypeName"></param>
        /// <param name="secondTypeName"></param>
        /// <param name="occurrenceName"></param>
        /// <param name="firstAbilityName"></param>
        /// <param name="secondAbilityName"></param>
        /// <param name="hiddenAbilityName"></param>
        /// <param name="sexName"></param>
        public void AddPokemon(string name, int hp, int attack, int defence, int specialAttack, int specialDefence, int speed, int sum, string  firstTypeName, string secondTypeName,  string occurrenceName, string firstAbilityName, string secondAbilityName, string hiddenAbilityName, string sexName)
        {
            string queryGetFirstTypeId = "SELECT Id FROM FirstType WHERE FirstTypeName='" + firstTypeName + "';";
            string queryGetSecondTypeId = "SELECT Id FROM SecondType WHERE SecondTypeName='" + secondTypeName + "';";
            string queryGetOccurrenceId = "SELECT Id FROM Occurrence WHERE Occurrence='" + occurrenceName + "';";
            string queryGetFirstAbilityId = "SELECT Id FROM FirstAbility WHERE FirstAbilityName ='" + firstAbilityName + "';";
            string queryGetSecondAbilityId = "SELECT Id FROM SecondAbility WHERE SecondAbilityName ='" + secondAbilityName + "';";
            string queryGetHiddenAbilityId = "SELECT Id FROM HiddenAbility WHERE HiddenAbilityName ='" + hiddenAbilityName + "';";
            string queryGetSexId = "SELECT Id FROM Sex WHERE SexName ='" + sexName + "';";

            _connection.Open();

            SqlCommand commandGetFirstTypeId = new SqlCommand(queryGetFirstTypeId, _connection);
            int firstTypeId = (int)commandGetFirstTypeId.ExecuteScalar();

            SqlCommand commandGetSecondTypeId = new SqlCommand(queryGetSecondTypeId, _connection);
            int secondTypeId = (int)commandGetSecondTypeId.ExecuteScalar();

            SqlCommand commandGetOccurrenceId = new SqlCommand(queryGetOccurrenceId, _connection);
            int occurrenceId = (int)commandGetOccurrenceId.ExecuteScalar();

            SqlCommand commandGetFirstAbilityId = new SqlCommand(queryGetFirstAbilityId, _connection);
            int firstAbilityId = (int)commandGetFirstAbilityId.ExecuteScalar();
            
            SqlCommand commandGetSecondAbilityId = new SqlCommand(queryGetSecondAbilityId, _connection);
            int secondAbilityId = (int)commandGetSecondAbilityId.ExecuteScalar();

            SqlCommand commandGetHiddenAbilityId = new SqlCommand(queryGetHiddenAbilityId, _connection);
            int hiddenAbilityId = (int)commandGetHiddenAbilityId.ExecuteScalar();

            SqlCommand commandGetSexId = new SqlCommand(queryGetSexId, _connection);
            int sexId = (int)commandGetSexId.ExecuteScalar();

            string insertPokemonQuery = "INSERT INTO Pokemons "+"(Name, HP, Attack, Defence, SpecialAttack, SpecialDefence, Speed, Sum, FirstTypeId, SecondTypeId, OccurrenceId, FirstAbilityId, SecondAbilityId, HiddenAbilityId, SexId) VALUES ('" + name + "'," + hp + "," + attack + "," + defence + "," + specialAttack + "," + specialDefence + "," + speed + "," + sum + "," + firstTypeId + "," + secondTypeId + "," + occurrenceId + "," + firstAbilityId + "," + secondAbilityId + "," + hiddenAbilityId + "," + sexId + ");";
            SqlCommand commandInsertPokemon = new SqlCommand(insertPokemonQuery, _connection);
            commandInsertPokemon.ExecuteNonQuery();

            _connection.Close();
        }

        /// <summary>
        /// Metoda edytująca pokemona z tabeli Pokemons
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="hp"></param>
        /// <param name="attack"></param>
        /// <param name="defence"></param>
        /// <param name="specialAttack"></param>
        /// <param name="specialDefence"></param>
        /// <param name="speed"></param>
        /// <param name="sum"></param>
        /// <param name="firstTypeName"></param>
        /// <param name="secondTypeName"></param>
        /// <param name="occurrenceName"></param>
        /// <param name="firstAbilityName"></param>
        /// <param name="secondAbilityName"></param>
        /// <param name="hiddenAbilityName"></param>
        /// <param name="sexName"></param>
        public void EditPokemon (int id, string name, int hp, int attack, int defence, int specialAttack, int specialDefence, int speed, int sum, string firstTypeName, string secondTypeName, string occurrenceName, string firstAbilityName, string secondAbilityName, string hiddenAbilityName, string sexName)
        {
            string queryGetFirstTypeId = "SELECT Id FROM FirstType WHERE FirstTypeName='" + firstTypeName + "';";
            string queryGetSecondTypeId = "SELECT Id FROM SecondType WHERE SecondTypeName='" + secondTypeName + "';";
            string queryGetOccurrenceId = "SELECT Id FROM Occurrence WHERE Occurrence='" + occurrenceName + "';";
            string queryGetFirstAbilityId = "SELECT Id FROM FirstAbility WHERE FirstAbilityName ='" + firstAbilityName + "';";
            string queryGetSecondAbilityId = "SELECT Id FROM SecondAbility WHERE SecondAbilityName ='" + secondAbilityName + "';";
            string queryGetHiddenAbilityId = "SELECT Id FROM HiddenAbility WHERE HiddenAbilityName ='" + hiddenAbilityName + "';";
            string queryGetSexId = "SELECT Id FROM Sex WHERE SexName ='" + sexName + "';";

            _connection.Open();

            SqlCommand commandGetFirstTypeId = new SqlCommand(queryGetFirstTypeId, _connection);
            int firstTypeId = (int)commandGetFirstTypeId.ExecuteScalar();

            SqlCommand commandGetSecondTypeId = new SqlCommand(queryGetSecondTypeId, _connection);
            int secondTypeId = (int)commandGetSecondTypeId.ExecuteScalar();

            SqlCommand commandGetOccurrenceId = new SqlCommand(queryGetOccurrenceId, _connection);
            int occurrenceId = (int)commandGetOccurrenceId.ExecuteScalar();

            SqlCommand commandGetFirstAbilityId = new SqlCommand(queryGetFirstAbilityId, _connection);
            int firstAbilityId = (int)commandGetFirstAbilityId.ExecuteScalar();

            SqlCommand commandGetSecondAbilityId = new SqlCommand(queryGetSecondAbilityId, _connection);
            int secondAbilityId = (int)commandGetSecondAbilityId.ExecuteScalar();

            SqlCommand commandGetHiddenAbilityId = new SqlCommand(queryGetHiddenAbilityId, _connection);
            int hiddenAbilityId = (int)commandGetHiddenAbilityId.ExecuteScalar();

            SqlCommand commandGetSexId = new SqlCommand(queryGetSexId, _connection);
            int sexId = (int)commandGetSexId.ExecuteScalar();

            string updatePokemonQuery = "UPDATE Pokemons SET Name='" + name + "', HP=" + hp + ", Attack=" + attack + ", Defence=" + defence + ", SpecialAttack=" + specialAttack + ", SpecialDefence=" + specialDefence + ", Speed=" + speed + ", Sum=" + sum + ", FirstTypeId=" + firstTypeId + ", SecondTypeId=" + secondTypeId + ", OccurrenceId=" + occurrenceId  + ", FirstAbilityId=" + firstAbilityId + ", SecondAbilityId=" + secondAbilityId + ", HiddenAbilityId=" + hiddenAbilityId + ", SexId=" + sexId + " WHERE Id=" + id + ";";
            
            SqlCommand commandInsertPokemon = new SqlCommand(updatePokemonQuery, _connection);
            commandInsertPokemon.ExecuteNonQuery();
        }

        /// <summary>
        /// Metoda usuwająca pokemona z tabeli Pokemons na postawie Id
        /// </summary>
        /// <param name="pokemonId"></param>
        public void DeletePokemon (int pokemonId)
        {
            string queryDeletePokemon = "DELETE FROM Pokemons WHERE Id=" + pokemonId;

            _connection.Open();

            SqlCommand commandDeletePokemon = new SqlCommand(queryDeletePokemon, _connection);
            commandDeletePokemon.ExecuteNonQuery();

            _connection.Close();
        }
    }
}
