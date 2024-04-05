using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionEleve.Instructeur;
using GestionEleve.Utils;
using System.Data.OleDb;

namespace GestionInstructeur.Instructeur
{
    class InstructeurController
    {
        private int maxId;

        public InstructeurController()
        {
            maxId = this.GetMaxId();
        }

        public void AddInstructeur(InstructeurModel Instructeur)
        {
            string query = "INSERT INTO Instructeur (ID_INSTRUCTEUR, CIN, NOM_COMPLET, DATE_DE_NAISSANCE, SCORE, MATIERE) VALUES (?, ?, ?, ?, ?, ?)";
            Connection.ExecuteNonQuery(query, maxId + 1,Instructeur.CIN, Instructeur.NOM_COMPLET, Instructeur.DATE_DE_NAISSANCE, Instructeur.SCORE, Instructeur.MATIERE);
            maxId++;
        }


        public void ModifyInstructeur(InstructeurModel Instructeur)
        {
            string query = "UPDATE Instructeur SET CIN = ?, " +
                           "NOM_COMPLET = ?, " +
                           "DATE_DE_NAISSANCE = ?, " +
                           "SCORE = ?, " +
                           "MATIERE = ?" +
                           "WHERE ID_INSTRUCTEUR = ?";

            Connection.ExecuteNonQuery(query, Instructeur.CIN, Instructeur.NOM_COMPLET, Instructeur.DATE_DE_NAISSANCE, Instructeur.SCORE, Instructeur.MATIERE,Instructeur.ID_INSTRUCTEUR);
        }

        public List<InstructeurModel> GetAllInstructeurs(String key = "")
        {
            List<InstructeurModel> Instructeurs = new List<InstructeurModel>();
            string query = "SELECT * FROM INSTRUCTEUR WHERE NOM_COMPLET Like @key";

            using (OleDbConnection connection = new OleDbConnection(Connection.getConnectionString()))
            {
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@key", "%" + key + "%");
                        OleDbDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            InstructeurModel Instructeur = new InstructeurModel(
                                reader.GetInt16(0),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetDateTime(3).ToString("dd/MM/yyyy"),
                                reader.GetInt16(4),
                                reader.GetString(5)
                            );
                            Instructeurs.Add(Instructeur);
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error fetching instructeurs: " + ex.Message);
                    }
                }
            }
            return Instructeurs;
        }

        public void DeleteInstructeur(int id)
        {
            string query = "DELETE FROM Instructeur WHERE ID_Instructeur = ?";
            Connection.ExecuteNonQuery(query, id);
            maxId = 0;
        }

        public int GetMaxId()
        {
            int count = 0;
            string query = "SELECT MAX(id_Instructeur) FROM Instructeur";
            using (OleDbConnection connection = new OleDbConnection(Connection.getConnectionString()))
            {
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    try
                    {
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
