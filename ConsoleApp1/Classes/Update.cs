using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    public class Update
    {
        public void update()
        {
            string cs = "Data Source=./Employee.db";
            using var con = new SQLiteConnection(cs);
            con.Open();
            using var cmd = new SQLiteCommand(con);

            Console.WriteLine("\nEnter id you want to update\n");
            int updateId = int.Parse(Console.ReadLine());


            Console.WriteLine("\nEnter Date\n");
            string enterDate = Console.ReadLine();
            var convDate = DateOnly.Parse(enterDate);
            string fullDate = convDate.ToString();
            string trimDate = fullDate.Substring(0, 10);

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

            cmd.CommandText = $"UPDATE employee SET date = '{trimDate}', name = '{userName}',hours = {hours}, status = {statusbool}  WHERE id = {updateId}";
            cmd.ExecuteNonQuery();

            Console.WriteLine("\nUpdated Successfully\n");
        }
    }
}
