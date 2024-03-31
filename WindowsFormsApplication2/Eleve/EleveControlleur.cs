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
            Console.WriteLine(maxId);
        }

        public void AddEleve(EleveModel eleve){
            string query = "INSERT INTO Eleve (ID_ELEVE, NOMCOMPLET, DATENAISSANCE, DATEINSCRIPTION, SCORE) " +
                          "VALUES (?, ?, ?, ?, 10)";
            Connection.ExecuteNonQuery(query, maxId + 1 , eleve.nomComplet, eleve.dateNaissance, eleve.dateInscription);
        }


        public void ModifyEleve(EleveModel eleve)
        {
            string query = "UPDATE Eleve SET nomComplet = ?, " +
                           "dateNaissance = ?, " +
                           "dateInscription = ?, " +
                           "score = ? " +
                           "WHERE ID_ELEVE = ?";
            Connection.ExecuteNonQuery(query, eleve.nomComplet, eleve.dateNaissance, eleve.dateInscription, eleve.score, eleve.ID);
        }

        //public List<EleveModel> GetAllEleves()
        //{
        //    List<EleveModel> eleves = new List<EleveModel>();
        //    string query = "SELECT * FROM Eleve";
        //    using (OleDbConnection connection = new OleDbConnection(""))
        //    {
        //        using (OleDbCommand command = new OleDbCommand(query, connection))
        //        {
        //            try
        //            {
        //                connection.Open();
        //                OleDbDataReader reader = command.ExecuteReader();
        //                while (reader.Read())
        //                {
        //                    EleveModel eleve = new EleveModel
        //                    {
        //                        ID = reader.GetInt32(0),
        //                        nomComplet = reader.GetString(1),
        //                        dateNaissance = reader.GetString(2),
        //                        dateInscription = reader.GetString(3),
        //                        score = reader.GetInt32(4)
        //                    };
        //                    eleves.Add(eleve);
        //                }
        //                reader.Close();
        //            }
        //            catch (Exception ex)
        //            {
        //                Console.WriteLine("Error fetching students: " + ex.Message);
        //            }
        //        }
        //    }
        //    return eleves;
        //}

        public void DeleteEleve(int id)
        {
            string query = "DELETE FROM Eleve WHERE ID = ?";
            Connection.ExecuteNonQuery(query, id);
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
