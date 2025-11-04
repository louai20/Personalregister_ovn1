namespace Övning_1___Personalregister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personalregister personalregister = new Personalregister();

            while (true)
            {
                Console.WriteLine("\n--- Personalregister ---");
                Console.WriteLine("1. Lägg till anställd");
                Console.WriteLine("2. Ta bort anställd");
                Console.WriteLine("3. Visa alla anställda namn");
                Console.WriteLine("4. Visa anställd info");
                Console.WriteLine("5. Avsluta");
                Console.Write("Val: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddEmployee(personalregister);
                        break;
                    case "2":
                        RemoveEmployee(personalregister);
                        break;
                    case "3":
                        personalregister.ShowAllEmployeeNames();
                        break;
                    case "4":
                        ShowEmployeeInfo(personalregister);
                        break;
                    case "5":
                        Console.WriteLine("Program avslutat!");
                        return;
                    default:
                        Console.WriteLine("Ogiltigt val. Försök igen.");
                        break;
                }

            }
        }

        static void AddEmployee(Personalregister personalregister)
        {
            Console.Write("Förnamn: ");
            string firstName = Console.ReadLine();
            Console.Write("Efternamn: ");
            string lastName = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Position: ");
            string position = Console.ReadLine();
            Console.Write("Lön: ");
            double salary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ålder: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Födelsedatum (YYYY-MM-DD): ");
            DateTime birthDay = DateTime.Parse(Console.ReadLine());
            Employee newEmployee = new Employee(firstName, lastName, email, position,
                                                salary, age, birthDay);
            personalregister.AddEmployee(newEmployee);
            Console.WriteLine("Anställd tillagd.");
        }

        static void RemoveEmployee(Personalregister personalregister) {
            Console.Write("Förnamn på anställd att ta bort: ");
            string firstName = Console.ReadLine();
            Console.Write("Efternamn på anställd att ta bort: ");
            string lastName = Console.ReadLine();
            var employees = personalregister.GetAllEmployees();
            foreach (var e in employees)
            {
                if (e.firstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) && e.lastName.Equals(lastName, StringComparison.OrdinalIgnoreCase))
                {
                    personalregister.RemoveEmployee(e);
                    Console.WriteLine("Anställd borttagen.");
                    return;
                }
            }
            Console.WriteLine("Ingen anställd hittades.");
        }

        static void ShowEmployeeInfo(Personalregister personalregister) {
            Console.Write("Förnamn på anställd: ");
            string firstName = Console.ReadLine();
            Console.Write("Efternamn på anställd: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("----------------------------------------------------------");
            personalregister.ShowEmployeeInfo(firstName, lastName);
        }
    }
}
