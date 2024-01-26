   internal class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;

            while (!endApp)
                {

                //initialize variables
                string name = "";
                int age = 0;
                double height = 0;
                const int LEGAL_DRINKING_AGE = 21;
                const int verifyAge = 18;
                double doubleAge = 0;

                
                Console.WriteLine("Welcome to Your Personal Information System \n");
                
                //input name and store input to name variable
                Console.Write("Please enter your name: ");
                name = Console.ReadLine();

                //enter user age and check if age is greater than 0 not null
                Console.Write("Please enter your age: ");

                //try to parse the input as an integer and if true, assign the value to age
                while (!int.TryParse(Console.ReadLine(), out age) || age < 0)
                {
                    Console.WriteLine("Invalid input. Please enter a number\n");
                    Console.Write("Please enter your age: ");
                }

                //parse the input as a double and if true, assign the value to height
                Console.Write("Please enter your height in meters: ");
                while (!double.TryParse(Console.ReadLine(), out height) || height < 0)
                {
                    Console.WriteLine("Invalid input. Please enter a number\n");
                    Console.Write("Please enter your height in meters: ");
                }

                //convert age to a double data type
                doubleAge = Convert.ToDouble(age);
                

                Console.WriteLine("\n------------------------\nYour Personal Details:\nName: {0}\nAge: {1}\nHeight: {2} meters\n", name, doubleAge, height);
                
                //compare user's age to variable verifyAge
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

                //using ternary conditional operator 
                Console.WriteLine(age >= LEGAL_DRINKING_AGE ? "Cheers, {0}! You're legally allowed to enjoy alcoholic beverages.\n" : "Sorry, you are underage for drinking.\n", name);


                Console.WriteLine("Personal Details Presentation:");

                //embed variable (name, doubleAge, height) within the string
                string personalInfo = $"Your Personal Information: {name}, {doubleAge} years old, {height} meters tall";
                Console.WriteLine(personalInfo);
                Console.WriteLine("\n-----------------------------------------------------\nThank you for using your Personal Information System!\n-----------------------------------------------------\n");
                Console.Write("Press 'n' then Enter to close the app, OR press any other key and Enter to continue: ");

                //closes app if user input "n"
                if (Console.ReadLine().ToLower() == "n") endApp = true;

                Console.WriteLine("\n");

            }


        }

}