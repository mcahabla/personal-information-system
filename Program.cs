   internal class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;

            while (!endApp)
                {

                //declare variables
                string name = "";
                int age = 0;
                double height = 0;
                const int LEGAL_DRINKING_AGE = 21;
                const int verifyAge = 18;
                double doubleAge = 0;

                
                Console.WriteLine("\nWelcome to Your Personal Information System \n");
                
                //assigns the user's input to variable "name"
                Console.Write("Please enter your name: ");
                name = Console.ReadLine();

                //parse input to variable "age"
                Console.Write("Please enter your age: ");

                //loops the code until the user inputs a valid input (age should be a positive number)
                while (!int.TryParse(Console.ReadLine(), out age) || age < 0)
                {   
                    //if input is invalid. system prompts the user to input a valid age
                    Console.WriteLine("Invalid input. Please enter a number\n");
                    Console.Write("Please enter your age: ");
                }

                Console.Write("Please enter your height in meters: ");
                //loops the code until the user inputs a valid input (height should be a positive number)
                while (!double.TryParse(Console.ReadLine(), out height) || height < 0)
                {   
                    //if input is invalid. system prompts the user to input a valid height
                    Console.WriteLine("Invalid input. Please enter a number\n");
                    Console.Write("Please enter your height in meters: ");
                }

                //converts age to double data type
                doubleAge = Convert.ToDouble(age);
                

                Console.WriteLine("\n------------------------\nYour Personal Details:\nName: {0}\nAge: {1}\nHeight: {2} meters\n", name, doubleAge, height);
                
                //verifies if user's age is greater than 18 (compare age to verifyAge variable)
                Console.WriteLine("Age Check:");
                if (age >= verifyAge)
                {
                    Console.WriteLine("Welcome, {0}! You're eligible for additional features.\n", name);
                }
                else
                {
                    Console.WriteLine("You are still a minor\n");
                }

                //verifies if user's age is greater than 21 (compare age to LEGAL_DRINKING_AGE variable)
                Console.WriteLine("Legal Drinking Age Verification:");
                if (age >= LEGAL_DRINKING_AGE)
                {
                    Console.WriteLine("Cheers, {0}! You're legally allowed to enjoy alcoholic beverages.\n", name);
                }
                else
                {
                    Console.WriteLine("Sorry, you are underage for drinking.\n");
                }

                Console.WriteLine("Personal Details Presentation:");

                //assign string to variable "personalInfo"
                string personalInfo = $"Your Personal Information: {name}, {doubleAge} years old, {height} meters tall";

                //prints "personalInfo"
                Console.WriteLine(personalInfo);

                Console.WriteLine("\n-----------------------------------------------------\nThank you for using your Personal Information System!\n-----------------------------------------------------\n");
                Console.Write("Press 'n' then Enter to close the app, OR press any other key and Enter to continue: ");
                if (Console.ReadLine().ToLower() == "n") endApp = true;

                Console.WriteLine("\n");

            }


        }

}