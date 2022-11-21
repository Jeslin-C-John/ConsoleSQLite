using System.Data.SQLite;

class Program
{
    public static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!OK");

        //string cs = "Data Source=:memory:";

        string cs = "Data Source=./Tasks.db";

        //string stm = "Data Source=:memory:";

        using var con = new SQLiteConnection(cs);
        con.Open();

        //using var cmd = new SQLiteCommand(stm, con);
        using var cmd = new SQLiteCommand(con);

        //string version = cmd.ExecuteScalar().ToString();
        //Console.WriteLine($"SQLite version: {version}");


        cmd.CommandText = "DROP TABLE IF EXISTS employees";
        cmd.ExecuteNonQuery();

        cmd.CommandText = @"CREATE TABLE employees(id INTEGER PRIMARY KEY,
            name TEXT, hours INT)";
        cmd.ExecuteNonQuery();

        cmd.CommandText = "INSERT INTO employees(name, hours) VALUES('Tester',4)";
        cmd.ExecuteNonQuery();

        cmd.CommandText = "INSERT INTO employees(name, hours) VALUES('ios',8)";
        cmd.ExecuteNonQuery();

        cmd.CommandText = "INSERT INTO employees(name, hours) VALUES('Tester',4)";
        cmd.ExecuteNonQuery();

        cmd.CommandText = "INSERT INTO employees(name, hours) VALUES('Tester',4)";
        cmd.ExecuteNonQuery();

        cmd.CommandText = "INSERT INTO employees(name, hours) VALUES('Tester',4)";
        cmd.ExecuteNonQuery();

        cmd.CommandText = "INSERT INTO employees(name, hours) VALUES('Tester',4)";
        cmd.ExecuteNonQuery();

        cmd.CommandText = "INSERT INTO employees(name, hours) VALUES('Tester',4)";
        cmd.ExecuteNonQuery();


        Console.WriteLine("Table cars created");


    }
}