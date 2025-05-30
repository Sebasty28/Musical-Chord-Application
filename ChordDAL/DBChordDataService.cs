using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using ChordCommon;

namespace ChordDAL
{
    internal class DBChordDataService : IChordDataService
    {
        // Connection string
        private static string connectionString =
            "Data Source=DESKTOP-IUD9FSK\\SQLEXPRESS;Initial Catalog=MusicalChordApp;Integrated Security=True;TrustServerCertificate=True;";

        public void Add(Chord chord)
        {
            string insertStatement = "INSERT INTO ChordDetails (ChordName, ChordType) VALUES (@ChordName, @ChordType)";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            using (SqlCommand insertCommand = new SqlCommand(insertStatement, sqlConnection))
            {
                insertCommand.Parameters.AddWithValue("@ChordName", chord.Name);
                insertCommand.Parameters.AddWithValue("@ChordType", chord.Type);

                sqlConnection.Open();
                insertCommand.ExecuteNonQuery();
            }
        }

        public List<Chord> GetAll()
        {
            string selectStatement = "SELECT ChordName, ChordType FROM ChordDetails";

            var chords = new List<Chord>();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            using (SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection))
            {
                sqlConnection.Open();
                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var name = reader["ChordName"].ToString();
                        var type = reader["ChordType"].ToString();
                        var notes = reader["ChordType"].ToString();
                        chords.Add(new Chord(name, type, notes));
                    }
                }
            }

            return chords;
        }

        public void Remove(Chord chord)
        {
            string deleteStatement = "DELETE FROM ChordDetails WHERE ChordName = @ChordName";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            using (SqlCommand deleteCommand = new SqlCommand(deleteStatement, sqlConnection))
            {
                deleteCommand.Parameters.AddWithValue("@ChordName", chord.Name);

                sqlConnection.Open();
                deleteCommand.ExecuteNonQuery();
            }
        }

        public void UpdateAccount(Chord chord)
        {
            string updateStatement =
                "UPDATE ChordDetails SET ChordType = @ChordType WHERE ChordName = @ChordName";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            using (SqlCommand updateCommand = new SqlCommand(updateStatement, sqlConnection))
            {
                updateCommand.Parameters.AddWithValue("@ChordName", chord.Name);
                updateCommand.Parameters.AddWithValue("@ChordType", chord.Type);

                sqlConnection.Open();
                updateCommand.ExecuteNonQuery();
            }
        }

        public void Save(List<Chord> chords)
        {
            foreach (var chord in chords)
            {
                Add(chord);
            }
        }
    }
}
