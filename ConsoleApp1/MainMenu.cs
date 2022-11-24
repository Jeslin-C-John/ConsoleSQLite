using ConsoleApp1.Classes;
using ConsoleApp1.folder;
using System.Data.SQLite;
using static System.Net.Mime.MediaTypeNames;

class MainMenu
{
    public static void Main(string[] args)
    {

        Int32 menuExit = 1;
        while (menuExit == 1)
        {
            Console.WriteLine("Choose Option\n\n1. Add \n2. View \n3. Update \n4. Delete \n5. Report \n6. Exit\n");

            int option;

            do
            {
                string optionString = Console.ReadLine();
                int.TryParse(optionString, out option);

                if (option == 0)
                {
                    Console.WriteLine("Invalid Input! Try Again!");
                    Console.WriteLine("Choose Option\n\n1. Add \n2. View \n3. Update \n4. Delete \n5. Report \n6. Exit\n");
                }
            }while(option == 0);

            

            switch (option)
            {
                case 1:
                    Add addobj = new Add();
                    addobj.add();
                    break;

                case 2:
                    View viewobj = new View();
                    viewobj.view();
                    break;

                case 3:
                    Update updateobj = new Update();
                    updateobj.update();
                    break;

                case 4:
                    Delete deleteobj = new Delete();
                    deleteobj.delete();
                    break;

                case 5:
                    Report reportobj = new Report();
                    reportobj.report();
                    break;

                case 6:menuExit = 0;
                    break;

                default:Console.WriteLine("Invalid Input! Try Again!");
                    break;
                    
            }
        }
    }
}