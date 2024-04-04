using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionEleve.Utils;
using System.Data.OleDb;

namespace GestionEleve.Eleve
{
    class EleveControlleur{
        private int maxId;

        public EleveControlleur(){
            maxId = this.GetMaxId();
        }

        public void AddEleve(EleveModel eleve){
            string query = "INSERT INTO Eleve (ID_ELEVE, NOM_COMPLET, DATE_DE_NAISSANCE, DATE_INSCRIPTION, SCORE, CLASSIFICATION) VALUES (?, ?, ?, ?, ?, ?)";
            Connection.ExecuteNonQuery(query, maxId + 1, eleve.NOM_COMPLET, eleve.DATE_DE_NAISSANCE, eleve.DATE_INSCRIPTION, eleve.SCORE, eleve.CLASSIFICATION); 
            query = "INSERT INTO INSCRIPTION (ID_ELEVE,ANNEE1) VALUES (?, ?)";
            Connection.ExecuteNonQuery(query, maxId + 1, StaticMethods.GetYearFromDate(eleve.DATE_INSCRIPTION));
            
            maxId++;
        }


        public void ModifyEleve(EleveModel eleve){
            string query = "UPDATE Eleve SET NOM_COMPLET = ?, " +
                           "DATE_DE_NAISSANCE = ?, " +
                           "DATE_INSCRIPTION = ?, " +
                           "SCORE = ?, " +
                           "CLASSIFICATION = ?" + 
                           "WHERE ID_ELEVE = ?";
     
            Connection.ExecuteNonQuery(query, eleve.NOM_COMPLET, eleve.DATE_DE_NAISSANCE, eleve.DATE_INSCRIPTION, eleve.SCORE, eleve.CLASSIFICATION, eleve.ID_ELEVE);
        }

        public List<EleveModel> GetAllEleves(String key = "", int year = -1)
        {
            List<EleveModel> eleves = new List<EleveModel>();
            string query = "SELECT * FROM Eleve";

            using (OleDbConnection connection = new OleDbConnection(Connection.getConnectionString()))
            {
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        OleDbDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            EleveModel eleve = new EleveModel(
                                reader.GetInt16(0),
                                reader.GetString(1),
                                reader.GetDateTime(2).ToString("dd/MM/yyyy"),
                                reader.GetDateTime(3).ToString("dd/MM/yyyy"),
                                reader.GetInt32(4),
                                reader.GetString(5)
                            );
                            eleves.Add(eleve);
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error fetching students: " + ex.Message);
                    }
                }
            }
            return eleves;
        }

        public List<EleveModel> GetAllElevesByYear(String key = "", int year = -1)
        {
            List<EleveModel> eleves = new List<EleveModel>();
            string query = "SELECT ELEVE.*" +
                " FROM ELEVE INNER JOIN INSCRIPTION ON ELEVE.ID_ELEVE = INSCRIPTION.ID_ELEVE" +
                " WHERE (((INSCRIPTION.ANNEE1) = @year) AND ((ELEVE.NOM_COMPLET) Like @key))";

            using (OleDbConnection connection = new OleDbConnection(Connection.getConnectionString()))
            {
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@year", year);
                        command.Parameters.AddWithValue("@key", "%" + key + "%"); // Add wildcards to the key
                        OleDbDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            EleveModel eleve = new EleveModel(
                                reader.GetInt16(0),
                                reader.GetString(1),
                                reader.GetDateTime(2).ToString("dd/MM/yyyy"),
                                reader.GetDateTime(3).ToString("dd/MM/yyyy"),
                                reader.GetInt32(4),
                                reader.GetString(5)
                            );
                            eleves.Add(eleve);
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error fetching students: " + ex.Message);
                    }
                }
            }
            return eleves;
        }

        public void DeleteEleve(int id)
        {
            string query = "DELETE FROM Eleve WHERE ID_ELEVE = ?";
            Connection.ExecuteNonQuery(query,id);
            maxId = 0;
        }

        public int GetMaxId()
        {
            int count = 0;
            string query = "SELECT MAX(id_eleve) FROM Eleve";
            using (OleDbConnection connection = new OleDbConnection(Connection.getConnectionString()))
            {
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    try{
                        connection.Open();
                        var result = command.ExecuteScalar();
                        if (result != null)
                        {
                            int.TryParse(result.ToString(), out count);
                        }
                        else count = -1;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error getting student index: " + ex.Message);
                    }
                }
            }
            return count;
        }

    }
}
