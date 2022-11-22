using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.folder
{
    internal class Add
    {
        public void addnew()
        {
            string cs = "Data Source=./Employee.db";
            using var con = new SQLiteConnection(cs);
            con.Open();
            using var cmd = new SQLiteCommand(con);

            //cmd.CommandText = "DROP TABLE IF EXISTS employee";
            //cmd.ExecuteNonQuery();

            //cmd.CommandText = @"CREATE TABLE employee(id INTEGER PRIMARY KEY, date TEXT, name TEXT, hours INT,status INT)";
            //cmd.ExecuteNonQuery();

            Console.WriteLine("\nEnter Name\n");
            string userName = Console.ReadLine();

            Console.WriteLine("\nEnter Worked Hours\n");
            int.TryParse(Console.ReadLine(), out int hours);

            bool statusbool;
            char statuschar;
            Console.WriteLine("\nDid you complete your work: y/n \n");
            statuschar = Console.ReadLine()[0];
            if (statuschar == 'y')
                statusbool = true;
            else
                statusbool = false;


            cmd.CommandText = "insert into employee(date, name, hours, status) values(@date, @name, @hours, @status)";
            cmd.Parameters.AddWithValue("@date", DateTime.Now);
            cmd.Parameters.AddWithValue("@name", userName);
            cmd.Parameters.AddWithValue("@hours", hours);
            cmd.Parameters.AddWithValue("@status", statusbool);
            cmd.Prepare();
            cmd.ExecuteNonQuery();

            Console.WriteLine("\nInserted Successfully\n");

        }
    }
}
