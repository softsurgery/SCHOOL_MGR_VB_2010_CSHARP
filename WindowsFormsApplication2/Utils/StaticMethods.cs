using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace GestionEleve.Utils
{
    class StaticMethods{
        public static int CalculateDateDifferenceInYears(string date1, string date2){
            DateTime dt1 = DateTime.ParseExact(date1, "dd/MM/yyyy", null);
            DateTime dt2 = DateTime.ParseExact(date2, "dd/MM/yyyy", null);
            int yearsDiff = dt2.Year - dt1.Year;
            if (dt1.Month > dt2.Month || (dt1.Month == dt2.Month && dt1.Day > dt2.Day)){
                yearsDiff--;
            }
            return yearsDiff;
        }

        public static string GetTodayDate(){
            return DateTime.Now.ToString("dd/MM/yyyy");
        }

        public static List<String> getFileNames(String dataFolderRelativePath){
            string dataFolderPath = Path.Combine(Directory.GetCurrentDirectory(), dataFolderRelativePath);
            if (Directory.Exists(dataFolderPath))
            {
                string[] files = Directory.GetFiles(dataFolderPath);
                List<String> names = new List<string>();
                foreach (string file in files)
                {
                    names.Add(Path.GetFileName(file));
                }
                return names;
            }
            else
            {
                Console.WriteLine("Data folder does not exist.");
            }
            return null;
        }

        public static void SaveSelectedDate(string selectedDate)
        {
            string directory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Data");
            string filePath = Path.Combine(directory, "config");

            try
            {
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine(selectedDate);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving selected date: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static int ReadYearFromFile()
        {
            try
            {
                string content = File.ReadAllText(@"..\..\Data\config");
                int integerValue;
                if (int.TryParse(content, out integerValue))
                {
                    return integerValue;
                }
                else
                {
                    throw new FormatException("File does not contain a valid integer.");
                }
            }
            catch (Exception ex)
            {
                throw new IOException("Error reading integer from file: " + ex.Message);
            }
        }
        public static int GetYearFromDate(string dateString)
        {
            DateTime date;
            if (DateTime.TryParseExact(dateString, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out date))
            {
                int year = date.Year;
                return year;
            }
            else
            {
                return -1;
            }
        }
    }
}
