using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace GestionEleve.Utils{
    class Connection{
         private string connectionString;

         public Connection(string connectionString){
            this.connectionString = connectionString;
        }

         private void ExecuteNonQuery(string query){
             using (OleDbConnection connection = new OleDbConnection(connectionString)){
                 using (OleDbCommand command = new OleDbCommand(query, connection)){
                     try{
                         connection.Open();
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
