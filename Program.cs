   internal class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;

            while (!endApp)
                {
                string name = "";
                int age = 0;
                double height = 0;
                const int LEGAL_DRINKING_AGE = 21;
                const int verifyAge = 18;
                double doubleAge = 0;

                
                Console.WriteLine("\nWelcome to Your Personal Information System \n");

                Console.Write("Please enter your name: ");
                name = Console.ReadLine();
                Console.Write("Please enter your age: ");
                while (!int.TryParse(Console.ReadLine(), out age) || age < 0)
                {
                    Console.WriteLine("Invalid input. Please enter a number\n");
                    Console.Write("Please enter your age: ");
                }
                Console.Write("Please enter your height in meters: ");
                while (!double.TryParse(Console.ReadLine(), out height) || height < 0)
                {
                    Console.WriteLine("Invalid input. Please enter a number\n");
                    Console.Write("Please enter your height in meters: ");
                }

                doubleAge = Convert.ToDouble(age);
                

                Console.WriteLine("\n------------------------\nYour Personal Details:\nName: {0}\nAge: {1}\nHeight: {2} meters\n", name, doubleAge, height);

                Console.WriteLine("Age Check:");
                if (age >= verifyAge)
                {
                    Console.WriteLine("Welcome, {0}! You're eligible for additional features.\n", name);
                }
                else
                {
                    Console.WriteLine("You are still a minor\n");
                }

                Console.WriteLine("Legal Drinking Age Verification:");
                if (age >= LEGAL_DRINKING_AGE)
                {
                    Console.WriteLine("Cheers, {0}! You're legally allowed to enjoy alcoholic beverages.\n", name);
                }
                else
                {
                    Console.WriteLine("Sorry, you are underage for drinking.\n");
                }

                // String Manipulation
                Console.WriteLine("Personal Details Presentation:");
                string personalInfo = $"Your Personal Information: {name}, {doubleAge} years old, {height} meters tall";
                Console.WriteLine(personalInfo);
                Console.WriteLine("\n-----------------------------------------------------\nThank you for using your Personal Information System!\n-----------------------------------------------------\n");
                Console.Write("Press 'n' then Enter to close the app, OR press any other key and Enter to continue: ");
                if (Console.ReadLine().ToLower() == "n") endApp = true;

                Console.WriteLine("\n");

            }


        }

}