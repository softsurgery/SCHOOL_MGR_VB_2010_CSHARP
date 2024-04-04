using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using GestionEleve.Utils;

namespace GestionEleve.Autre.AnneeScolaire
{
    class AnneeController
    {
         private int maxId;

         public AnneeController() {}

        public void AddAnnee(AnneeModel annee){
            string query = "INSERT INTO ANNEE_SCOLAIRE (ANNEE1, ANNEE2) VALUES (?, ?)";
            Connection.ExecuteNonQuery(query,annee.ANNEE1, annee.ANNEE2);
        }

        public List<AnneeModel> GetAllAnnee(string key = "")
        {
            List<AnneeModel> eleves = new List<AnneeModel>();
            string query = "SELECT * FROM ANNEE_SCOLAIRE WHERE ANNEE1 LIKE @key OR ANNEE2 LIKE @key";
            using (OleDbConnection connection = new OleDbConnection(Connection.getConnectionString()))
            {
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@key", "%" + key + "%");
                        OleDbDataReader reader = command.ExecuteReader();
                        while (reader.Read()){
                            AnneeModel eleve = new AnneeModel(
                                reader.GetInt16(0),
                                reader.GetInt16(1)
                            );
                            eleves.Add(eleve);
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error fetching annee: " + ex.Message);
                    }
                }
            }
            return eleves;
        }

        public void DeleteAnnee(int ANNEE1)
        {
            string query = "DELETE FROM ANNEE_SCOLAIRE WHERE ANNEE1 = ?";
            Connection.ExecuteNonQuery(query, ANNEE1);
        }

        public static string SubstringTillSlash(string input)
        {
            
            int slashIndex = input.IndexOf("/");
            if (slashIndex == -1)
            {
                return input;
            }
            return input.Substring(0, slashIndex);
        }

        public static bool CheckYearlyFormat(string input){
            if (input.Length != 9) return false;
            if (input[4] != '/') return false;

        int year1,year2;
        if (! int.TryParse(input.Substring(0, 4), out year1) )return false;
        if (!int.TryParse(input.Substring(5, 4), out year2))return false;

        if (year2 <= year1) return false;
        return true;
    }

    }
}
