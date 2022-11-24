using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    internal class Delete
    {
        public void delete()
        {
            string cs = "Data Source=./Employee.db";
            using var con = new SQLiteConnection(cs);
            con.Open();
            using var cmd = new SQLiteCommand(con);

            Console.WriteLine("\nEnter id you want to delete\n");
            int deleteId;
            do
            {
                int.TryParse(Console.ReadLine(), out deleteId);
                if (deleteId == 0)
                {
                    Console.WriteLine("\nEnter Valid id\n");
                }
            } while (deleteId == 0);

            cmd.CommandText = $"DELETE FROM employee WHERE id = {deleteId}";
            cmd.ExecuteNonQuery();

            Console.WriteLine("\nDeleted Successfully\n");
        }
    }
}
