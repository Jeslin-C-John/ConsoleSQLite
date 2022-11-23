using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    public class View
    {
        public void view()
        {
            String statusView;
            string cs = "Data Source=./Employee.db";
            using var con = new SQLiteConnection(cs);
            con.Open();
            string stm = "select * from employee";
            using var cmd = new SQLiteCommand(stm, con);
            using SQLiteDataReader rdr = cmd.ExecuteReader();

            Console.WriteLine($"{rdr.GetName(0)} {rdr.GetName(1),-10} {rdr.GetName(2),-10} {rdr.GetName(3),-10} {rdr.GetName(4),-10}\n");

            while (rdr.Read())
            {
                Int32 statusOut = rdr.GetInt32(4);
                if (statusOut == 0)
                    { statusView = "Incomplete"; }
                else
                    { statusView = "Completed"; }
                    
                Console.WriteLine($"{rdr.GetInt32(0),0} {rdr.GetString(1),-10} {rdr.GetString(2),-10} {rdr.GetInt32(3),-10} {statusView, -10} \n");
            }
        }
}
}
