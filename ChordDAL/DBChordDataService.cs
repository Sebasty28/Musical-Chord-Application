using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChordCommon;
using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;

namespace ChordDAL
{
    internal class DBChordDataService : IChordDataService
    {

        //connection string
        static string connectionString = "Data Source =DESKTOP-IUD9FSK\\SQLEXPRESS; Initial Catalog =MusicalChordApp; Integrated Security =True; TrustServerCertificate =True;";

        static SqlConnection sqlConnection;

        public DBChordDataService()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public void Add(Chord chord)
        {
            var insertStatement = "INSERT INTO ChordDetails VALUES (@ChordName, @ChordType)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, sqlConnection);

            insertCommand.Parameters.AddWithValue("@AccountNumber", chord.Name);
            insertCommand.Parameters.AddWithValue("@AccountName", chord.Type);
            sqlConnection.Open();

            insertCommand.ExecuteNonQuery();

            sqlConnection.Close();

        }

        public List<Chord> GetAll()
        {
            string selectStatement = "SELECT ChordName, ChordType";

            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);

            sqlConnection.Open();

            SqlDataReader reader = selectCommand.ExecuteReader();

            var chords = new List<Chord>();

            while (reader.Read())
            {
                //deserialize

                Chord chord = new Chord();
                chord.Name = reader["ChordName"].ToString();
                chord.Type = reader["ChordType"].ToString();

                chords.Add(chord);
            }

            sqlConnection.Close();
            return chords;

        }

        public void Remove(Chord chord)
        {
            sqlConnection.Open();

            var deleteStatement = $"DELETE FROM ChordDetails WHERE ChordName = @ChordName";
            SqlCommand updateCommand = new SqlCommand(deleteStatement, sqlConnection);
            updateCommand.Parameters.AddWithValue("@ChordName", chord.Name);

            updateCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public void UpdateAccount(Chord chord)
        {
            sqlConnection.Open();

            var updateStatement = $"UPDATE ChordDetails SET ChordName = @ChordName, ChordType = @ChordType";

            SqlCommand updateCommand = new SqlCommand(updateStatement, sqlConnection);

            updateCommand.Parameters.AddWithValue("@ChordName", chord.Name);
            updateCommand.Parameters.AddWithValue("@ChordType", chord.Type);
            updateCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public void Save(List<Chord> chords)
        {
            this.chords = chords;
        }
    }
}
