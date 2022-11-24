using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    internal class Report
    {
        public void report()
        {
            String statusView;
            string cs = "Data Source=./Employee.db";
            using var con = new SQLiteConnection(cs);
            con.Open();


            Console.WriteLine("\nEnter year\n");
            int searchYear;
            do
            {
                int.TryParse(Console.ReadLine(), out searchYear);
                if (searchYear == 0)
                {
                    Console.WriteLine("\nEnter Valid year\n");
                }
            } while (searchYear == 0);


            Console.WriteLine("\nEnter month\n");
            int searchMonth;
            do
            {
                int.TryParse(Console.ReadLine(), out searchMonth);
                if (searchMonth == 0 || searchMonth > 12)
                {
                    Console.WriteLine("\nEnter Valid month\n");
                }
            } while (searchMonth == 0 || searchMonth>12);


            //string stm = $"select * from employee WHERE date LIKE '___{searchMonth}_{searchYear}'";
            string stm;
            if (searchMonth < 10)
            {
                stm = $"SELECT * FROM employee WHERE date BETWEEN '{searchYear}-0{searchMonth}-01' AND '{searchYear}-0{searchMonth}-31'";
            }

        else
            {
                stm = $"SELECT * FROM employee WHERE date BETWEEN '{searchYear}-{searchMonth}-01' AND '{searchYear}-{searchMonth}-31'";
            }
            

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

                Console.WriteLine($"{rdr.GetInt32(0),0} {rdr.GetString(1),-10} {rdr.GetString(2),-10} {rdr.GetInt32(3),-10} {statusView,-10} \n");

                //var reportDate = DateOnly.Parse(rdr.GetString(1));
                //if (reportDate.Month.ToString() == searchMonth && reportDate.Year.ToString() == searchYear)
                //{
                //    Console.WriteLine($"{rdr.GetInt32(0),0} {rdr.GetString(1),-10} {rdr.GetString(2),-10} {rdr.GetInt32(3),-10} {statusView,-10} \n");
                //}

            }
        }
    }
}
