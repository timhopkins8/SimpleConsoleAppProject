

using SimpleConsoleAppProject;
string option = "";
do
{
   
    Console.WriteLine("Select one of the options below or press 'q' to exit:");
    Console.WriteLine();

    Console.WriteLine("1: Calculate your age");
    Console.WriteLine("2: Get Current Date and Time");
    Console.WriteLine("q: Quit the program");
    Console.Write("Enter the number from the menu: ");
    option = Console.ReadLine();

    switch (option)
    {
        case "1":
            Console.WriteLine("Enter your DOB in this format MM/DD/YYYY");            
            CalculateAge age = new CalculateAge(Console.ReadLine());
            Console.WriteLine($"You are {age.CalculateAgeFromDob()} years old.");
            break;
        case "2":
            Console.WriteLine($"The current date and time is {DateTime.Now.ToString("f")}");
            break;
        case "3":
            Console.WriteLine("Program is ending....");
            break;
        default:
            Console.WriteLine("Invalid options, Please enter a valid option.");
            break;
    }
    Console.WriteLine();
}
while (option != "q");
