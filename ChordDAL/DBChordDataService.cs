using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using ChordCommon;

namespace ChordDAL
{
    public class DBChordDataService : IChordDataService
    {
        private static string connectionString =
            "Data Source=DESKTOP-IUD9FSK\\SQLEXPRESS;Initial Catalog=MusicalChordApp;Integrated Security=True;TrustServerCertificate=True;";

        public void Add(Chord chord)
        {
            string insertStatement = "INSERT INTO ChordDetails (ChordName, ChordType, Notes) VALUES (@ChordName, @ChordType, @Notes)";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            using (SqlCommand insertCommand = new SqlCommand(insertStatement, sqlConnection))
            {
                insertCommand.Parameters.AddWithValue("@ChordName", chord.Name);
                insertCommand.Parameters.AddWithValue("@ChordType", chord.Type);
                insertCommand.Parameters.AddWithValue("@Notes", chord.Notes);

                sqlConnection.Open();
                insertCommand.ExecuteNonQuery();
            }
        }

        public List<Chord> GetAll()
        {
            string selectStatement = "SELECT ChordName, ChordType, Notes FROM ChordDetails";

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
                        var notes = reader["Notes"].ToString();
                        chords.Add(new Chord(name, type, notes));
                    }
                }
            }

            return chords;
        }

        public bool Delete(Chord chord)
        {
            string deleteStatement = "DELETE FROM ChordDetails WHERE ChordName = @ChordName AND ChordType = @ChordType";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            using (SqlCommand deleteCommand = new SqlCommand(deleteStatement, sqlConnection))
            {
                deleteCommand.Parameters.AddWithValue("@ChordName", chord.Name);
                deleteCommand.Parameters.AddWithValue("@ChordType", chord.Type);

                sqlConnection.Open();
                int rowsAffected = deleteCommand.ExecuteNonQuery();

                return rowsAffected > 0;
            }
        }

        public void Edit(Chord chord)
        {
            string updateStatement =
                "UPDATE ChordDetails SET Notes = @Notes WHERE ChordName = @ChordName AND ChordType = @ChordType";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            using (SqlCommand updateCommand = new SqlCommand(updateStatement, sqlConnection))
            {
                updateCommand.Parameters.AddWithValue("@ChordName", chord.Name);
                updateCommand.Parameters.AddWithValue("@ChordType", chord.Type);
                updateCommand.Parameters.AddWithValue("@Notes", chord.Notes);

                sqlConnection.Open();
                updateCommand.ExecuteNonQuery();
            }
        }

        public void Save(List<Chord> chords)
        {
            // Simplest implementation: delete all and re-insert.
            string deleteAllStatement = "DELETE FROM ChordDetails";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                using (SqlCommand deleteCommand = new SqlCommand(deleteAllStatement, sqlConnection))
                {
                    deleteCommand.ExecuteNonQuery();
                }

                foreach (var chord in chords)
                {
                    using (SqlCommand insertCommand = new SqlCommand(
                        "INSERT INTO ChordDetails (ChordName, ChordType, Notes) VALUES (@ChordName, @ChordType, @Notes)", sqlConnection))
                    {
                        insertCommand.Parameters.AddWithValue("@ChordName", chord.Name);
                        insertCommand.Parameters.AddWithValue("@ChordType", chord.Type);
                        insertCommand.Parameters.AddWithValue("@Notes", chord.Notes);
                        insertCommand.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
