using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace GestionEleve.Utils
{
    class Connection{

        private const String connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\DBAgence.accdb; Persist Security Info=False;";
        
        public static String getConnectionString(){
            return connectionString;
        }

        public static void ExecuteNonQuery(string query, params object[] parameters){
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(query, connection)){
                    try{
                        connection.Open();
                        for (int i = 0; i < parameters.Length; i++){
                            command.Parameters.AddWithValue("@param{i}", parameters[i]);
                        }
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex){
                        Console.WriteLine("Error executing query: " + ex.Message);
                    }
                }
            }
        }
    }
}
