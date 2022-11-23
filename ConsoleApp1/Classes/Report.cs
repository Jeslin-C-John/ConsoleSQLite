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

            Console.WriteLine("\nEnter month\n");
            var searchMonth =Console.ReadLine();

            Console.WriteLine("\nEnter year\n");
            var searchYear =Console.ReadLine();

            //string stm = $"select * from employee WHERE date LIKE '___{searchMonth}_{searchYear}'";
            string stm = "select * from employee where date > '01-02-2022'";

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
