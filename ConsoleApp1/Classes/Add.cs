using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.folder
{
    public class Add
    {
        public void add()
        {
            string cs = "Data Source=./Employee.db";
            using var con = new SQLiteConnection(cs);
            con.Open();
            using var cmd = new SQLiteCommand(con);

            //cmd.CommandText = "DROP TABLE IF EXISTS employee";
            //cmd.ExecuteNonQuery();
            //cmd.CommandText = @"CREATE TABLE employee(id INTEGER PRIMARY KEY, date TEXT, name TEXT, hours INT,status INT)";
            //cmd.ExecuteNonQuery();

            DateTime convDate;
            int dateValidFlag = 1;
            string invalidDateString = "01 - 01 - 0001 12:00:00 AM";
            DateTime invalidDate = DateTime.Parse(invalidDateString);
            Console.WriteLine("\nEnter Date (yyyy-mm-dd)\n");
            do
            {
                string enterDate = Console.ReadLine();
                DateTime.TryParse(enterDate, out convDate);

                if (convDate== invalidDate)
                {
                    Console.WriteLine("Enter a valid Date (yyyy-mm-dd)");
                    dateValidFlag = 0;
                }
                else
                {
                    dateValidFlag = 1;
                }
            } while (dateValidFlag==0);

            string stringDate = convDate.ToString("yyyy-MM-dd");


            Console.WriteLine("\nEnter Name\n");
            string userName="";
            do
            {
                
                userName = Console.ReadLine();
                if (userName == "")
                {
                    Console.WriteLine("\nEnter Valid Name\n");
                }
            } while (userName == "");


            Console.WriteLine("\nEnter Worked Hours\n");
            int hours;
            do
            {
                int.TryParse(Console.ReadLine(), out hours);
                if (hours == 0)
                {
                    Console.WriteLine("\nEnter Valid Hours\n");
                }
            } while (hours==0);


            bool statusbool = false;
            int statusInvalidFlag = 0;
            string statuschar;
            Console.WriteLine("\nDid you complete your work: y/n \n");
            do {
                statuschar = Console.ReadLine();
                if (statuschar == "y" || statuschar == "Y")
                { statusbool = true;
                    statusInvalidFlag = 0; }
                else if (statuschar == "n" || statuschar == "N")
                {  statusbool = false;
                    statusInvalidFlag = 0; }
                else if(statuschar == null)
                {
                    Console.WriteLine("Invalid! Enter valid Response");
                    statusInvalidFlag = 1;
                }
                else
                {
                    Console.WriteLine("Invalid! Enter valid Response");
                    statusInvalidFlag = 1;
                }
            } while (statusInvalidFlag==1);


            cmd.CommandText = "insert into employee(date, name, hours, status) values(@date, @name, @hours, @status)";
            cmd.Parameters.AddWithValue("@date", stringDate);
            cmd.Parameters.AddWithValue("@name", userName);
            cmd.Parameters.AddWithValue("@hours", hours);
            cmd.Parameters.AddWithValue("@status", statusbool);
            cmd.Prepare();
            cmd.ExecuteNonQuery();

            Console.WriteLine("\nInserted Successfully\n");

        }
    }
}
