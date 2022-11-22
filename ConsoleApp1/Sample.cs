//using System.Data.SQLite;

//class Sample
//{
//    public static void Main(string[] args)
//    {
//Console.WriteLine("Hello, World!OK");

//string cs = "Data Source=:memory:";

//string cs = "Data Source=./Tasks.db";

//string stm = "Data Source=:memory:";

//using var con = new SQLiteConnection(cs);
//con.Open();

//using var cmd = new SQLiteCommand(stm, con);
//using var cmd = new SQLiteCommand(con);

//string version = cmd.ExecuteScalar().ToString();
//Console.WriteLine($"SQLite version: {version}");


//cmd.CommandText = "DROP TABLE IF EXISTS employees";
//cmd.ExecuteNonQuery();

//cmd.CommandText = @"CREATE TABLE employees(id INTEGER PRIMARY KEY,
//            name TEXT, hours INT)";
//cmd.ExecuteNonQuery();

//cmd.CommandText = "INSERT INTO employees(name, hours) VALUES('Tester',4)";
//cmd.ExecuteNonQuery();

//cmd.CommandText = "INSERT INTO employees(name, hours) VALUES('ios',8)";
//cmd.ExecuteNonQuery();

//cmd.commandtext = "insert into employees(name, hours) values(@name, @price)";
//cmd.parameters.addwithvalue("@name", ".net");
//cmd.parameters.addwithvalue("@price", 6);
//cmd.prepare();
//cmd.executenonquery();

//cmd.Parameters.AddWithValue("@name", ".net copy");
//cmd.Parameters.AddWithValue("@price", 6);
//cmd.Prepare();

//cmd.ExecuteNonQuery();


//Console.WriteLine("Table employees created");



//        string stm = "SELECT * FROM employees LIMIT 4";
//        using var cmd = new SQLiteCommand(stm, con);
//        using SQLiteDataReader rdr = cmd.ExecuteReader();

//        Console.WriteLine($"{rdr.GetName(0)} {rdr.GetName(1),-10} {rdr.GetName(2),-10}");

//        while (rdr.Read())
//        {
//            Console.WriteLine($"{rdr.GetInt32(0)} {rdr.GetString(1),-10} {rdr.GetInt32(2),-10}");
//        }
//    }
//}