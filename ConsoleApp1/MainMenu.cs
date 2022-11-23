using ConsoleApp1.Classes;
using ConsoleApp1.folder;
using System.Data.SQLite;

class MainMenu
{
    public static void Main(string[] args)
    {

        Int32 menuExit = 1;
        while (menuExit == 1)
        {
            Console.WriteLine("Choose Option\n\n1. Add \n2. View \n3. Update \n4. Delete \n5. Report \n0. Exit\n");
            int.TryParse(Console.ReadLine(), out int option);

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

                case 0:menuExit = 0;
                    break;

                default:Console.WriteLine("Wrong Option\n\n");
                    break;
                    
            }
        }
    }
}