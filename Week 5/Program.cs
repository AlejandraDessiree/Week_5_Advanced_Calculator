// Week 5 - Alejandra Arauz - HCC
using Operations;
using static System.Console;
using static Menus.Menu;
using static System.Math;

class RuningCalc()
{
    public static void Main(string[] args)
    {
        Principal(); // Program Running
    }
}

namespace Menus
{
    class Menu()
    {
        public static void Principal()
        {
            List<string> UserOptions = new() {"1", "2", "3", "4", "5"};
            string userchoice;
            while (true)
            {
                WriteLine("=== OPTIONS ===\n1: Operations \n2: Complex Options \n3: Comparision of Numbers \n4: Logical Precedence \n5: Exit\n=== ======= ===");
                userchoice = ReadLine();
                if (UserOptions.Contains(userchoice) == false) //validation of options
                {
                    WriteLine("=== OPTIONS ===\n1: 1 \n2: 2 \n3: 3 \n4: Exit \n=== ======= ===");
                    userchoice = ReadLine();
                }
                else
                {
                    if (userchoice == "1")
                    {
                        Menu.FirstChoice();
                    }
                    else if (userchoice == "2")
                    {
                        Menu.SecondChoice();
                    }
                    else if (userchoice == "3")
                    {
                        Menu.ThirdOption();
                    }
                    else if (userchoice == "4")
                    {
                        OperationsAndLogic.LogicaExpresiones();
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
        public static void FirstChoice()
        {
            List<string> UserOptions = new() { "1", "2", "3", "4", "5"};
            string userchoice;
            WriteLine("=== OPTIONS ===\n1: Addition \n2: Substraction \n3: Division \n4: Multiplicacion \n5: Back \n=== ======= ===");
            userchoice = ReadLine();
            if (UserOptions.Contains(userchoice) == false) //validation of options
            {
                WriteLine("=== OPTIONS ===\n1: Addition \n2: Substraction \n3: Division \n4: Multiplicacion \n5: Back \n=== ======= ===");
                userchoice = ReadLine();
            }
            else
            {
                if (userchoice == "1")
                {
                    OperationsAndLogic.Suma();
                }
                else if (userchoice == "2")
                {
                    OperationsAndLogic.Resta();
                }
                else if (userchoice == "3")
                {
                    OperationsAndLogic.Division();
                }
                else if (userchoice == "4")
                {
                    OperationsAndLogic.Multiplicacion();
                }
                else
                {
                    Menu.Principal();
                }
            }
        }
        public static void SecondChoice()
        {
            List<string> UserOptions = new() { "1", "2", "3", "4", "5", "6"};
            string userchoice;
            WriteLine("=== OPTIONS ===\n1: Power \n2: Square Root \n3: Cosine \n4: Sine \n5: Tangent \n=== ======= ===");
            userchoice = ReadLine();
            if (UserOptions.Contains(userchoice) == false) //validation of options
            {
                WriteLine("=== OPTIONS ===\n1: Power \n2: Square Root \n3: Cosine \n4: Sine \n5: Tangent \n=== ======= ===");
                userchoice = ReadLine();
            }
            else
            {
                if (userchoice == "1")
                {
                    OperationsAndLogic.Potencia();
                }
                else if (userchoice == "2")
                {
                    OperationsAndLogic.RaizCuadrada();
                }
                else if (userchoice == "3")
                {
                    OperationsAndLogic.Coseno();
                }
                else if (userchoice == "4")
                {
                    OperationsAndLogic.Seno();
                }
                else if (userchoice == "5")
                {
                    OperationsAndLogic.Tangente();
                }
                else
                {
                    Menu.Principal();
                }
            }
        }
        public static void ThirdOption()
        {
            List<string> UserOptions = new() { "1", "2", "3", "4", "5"};
            string userchoice;
            WriteLine("=== OPTIONS ===\n1: It is possitive? \n2: Are equal? \n3: between 0 to 100? \n4: Results \n5: Back \n=== ======= ===");
            userchoice = ReadLine();
            if (UserOptions.Contains(userchoice) == false) //validation of options
            {
                WriteLine("=== OPTIONS ===\n1: It is possitive? \n2: Are equal? \n3: between 0 to 100? \n4: Results \n5: Back \n=== ======= ===");
                userchoice = ReadLine();
            }
            else
            {
                if (userchoice == "1")
                {
                    OperationsAndLogic.Posittive();
                }
                else if (userchoice == "2")
                {
                    OperationsAndLogic.Equals();
                }
                else if (userchoice == "3")
                {
                    OperationsAndLogic.InBetween();
                }
                else if (userchoice == "4")
                {
                    OperationsAndLogic.Resultados();
                }
                else
                {
                    Menu.Principal();
                }
            }
        }
    }
}

namespace Operations
{
    class OperationsAndLogic //The logic of each of the operations avaliable
    {
        public static void Suma()
        {
            WriteLine("Enter your first number: ");
            int.TryParse(ReadLine(), out int num1);
            WriteLine("Enter your second number: ");
            int.TryParse(ReadLine(), out int num2);
            WriteLine($"=== ======= ===\nYour result is: {num1 * num2}\n=== ======= ===");
        }
        public static void Resta()
        {
            WriteLine("Enter your first number: ");
            int.TryParse(ReadLine(), out int num1);
            WriteLine("Enter your second number: ");
            int.TryParse(ReadLine(), out int num2);
            WriteLine($"=== ======= ===\nYour result is: {num1 * num2}\n=== ======= ===");
        }
        public static void Division()
        {
            WriteLine("Enter your first number: ");
            int.TryParse(ReadLine(), out int num1);
            WriteLine("Enter your second number: ");
            int.TryParse(ReadLine(), out int num2);
            WriteLine($"=== ======= ===\nYour result is: {num1 * num2}\n=== ======= ===");
        }
        public static void Multiplicacion()
        {
            WriteLine("Enter your first number: ");
            int.TryParse(ReadLine(), out int num1);
            WriteLine("Enter your second number: ");
            int.TryParse(ReadLine(), out int num2);
            WriteLine($"=== ======= ===\nYour result is: {num1 * num2}\n=== ======= ===");
        }
        public static void Potencia()
        {
            WriteLine("Enter your number: ");
            int.TryParse(ReadLine(), out int num1);
            WriteLine("Enter your power: ");
            int.TryParse(ReadLine(), out int num2);
            WriteLine($"=== ======= ===\nYour result is: {Math.Pow(num1, num2)}\n=== ======= ===");
        }
        public static void RaizCuadrada()
        {
            WriteLine("Enter your number: ");
            int.TryParse(ReadLine(), out int num1);
            WriteLine($"=== ======= ===\nYour result is: {Math.Sqrt(num1)}\n=== ======= ===");
        }
        public static void Coseno()
        {
            WriteLine("Enter your number: ");
            int.TryParse(ReadLine(), out int num1);
            WriteLine($"=== ======= ===\nYour result is: {Math.Cos(num1)}\n=== ======= ===");
        }
        public static void Seno()
        {
            WriteLine("Enter your number: ");
            int.TryParse(ReadLine(), out int num1);
            WriteLine($"=== ======= ===\nYour result is: {Math.Sin(num1)}\n=== ======= ===");
        }
        public static void Tangente()
        {
            WriteLine("Enter your number: ");
            int.TryParse(ReadLine(), out int num1);
            WriteLine($"=== ======= ===\nYour result is: {Math.Tan(num1)}\n=== ======= ===");
        }
        public static void Posittive()
        {
            WriteLine("Enter your first number: ");
            int.TryParse(ReadLine(), out int num1);
            WriteLine("Enter your second number: ");
            int.TryParse(ReadLine(), out int num2);
            WriteLine($"=== ======= ===\nIs {num1} positive? {num1 > 0}\n=== ======= ===");
        }
        public static void Equals()
        {
            WriteLine("Enter your first number: ");
            int.TryParse(ReadLine(), out int num1);
            WriteLine("Enter your second number: ");
            int.TryParse(ReadLine(), out int num2);
            WriteLine($"=== ======= ===\nAre both numbers equal? {num1 == num2}\n=== ======= ===");
        }
        public static void InBetween()
        {
            WriteLine("Enter your first number: ");
            int.TryParse(ReadLine(), out int num1);
            WriteLine("Enter your second number: ");
            int.TryParse(ReadLine(), out int num2);
            WriteLine($"=== ======= ===\nIs {num1} between 0 and 100? {num1 >= 0 && num1 <= 100}\n=== ======= ===");
        }
        public static void Resultados()
        {
            WriteLine("Enter your first number: ");
            int.TryParse(ReadLine(), out int num1);
            WriteLine("Enter your second number: ");
            int.TryParse(ReadLine(), out int num2);
            if (num1 == num2)
            {
                WriteLine($"=== ======= ===\nIs Equal? {num1 == num2}");
            }
            else
            {
                WriteLine($"=== ======= ===\nIs Equal? {num1 != num2}");
            }
            if (num1 < num2)
            {
                WriteLine($"Is {num1} Less {num2} Than? {num1 < num2}");
            }
            else
            {
                WriteLine($"Is {num1} Less {num2} Than? {num1 < num2}");
            }
            if (num1 > num2)
            {
                WriteLine($"Is {num1} Greater {num2} Than? {num1 > num2}");
            }
            else
            {
                WriteLine($"Is {num1} Greater {num2} Than? {num1 > num2}");
            }
            WriteLine("=== ======= ===");
        }
        public static void LogicaExpresiones()
        {
            WriteLine("Enter your expresion: ");
            string expresion = ReadLine();
            if (expresion.Contains('*') || expresion.Contains('/'))
            {
                Console.WriteLine("Multiplication or Division have the highest precendence");
            }
            else
            {
                Console.WriteLine("No multiplication or division found.");
            }
            if (expresion.Contains('+') || expresion.Contains('-'))
            {
                Console.WriteLine("Addition or substraction have the lowest precendence");
            }
        }
    }
}