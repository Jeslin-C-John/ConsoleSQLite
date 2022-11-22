using ConsoleApp1.folder;
using System.Data.SQLite;

class MainMenu
{
    public static void Main(string[] args)
    {
        
        
        while (true)
        {
            Console.WriteLine("Choose Option\n\n1. Add \n2. View \n0. Exit\n");
            int.TryParse(Console.ReadLine(), out int option);

            switch (option)
            {
                case 1:Add addobj = new Add();
                    addobj.addnew();
                    break;

                case 0:goto exit_loop;

                default:Console.WriteLine("Wrong Option\n\n");
                    break;
                    
            }
        }
    exit_loop:;
    }
}