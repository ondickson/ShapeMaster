using E5._2Owusu;

class Program
{
    static void Main(string[] args)
    {
        // Main loop
        bool continueProgram = true;

        while (continueProgram)
        {
            DisplayMenu();

            Console.Write("\nEnter your choice: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int result))
            {
                switch (result)
                {
                    case 1:
                        Console.Write("Enter the radius of the circle: ");
                        double radius = double.Parse(Console.ReadLine());

                        Circle circle = new Circle(radius);

                        double area = circle.getArea();
                        double perimeter = circle.getPerimeter();

                        Console.WriteLine($"The area of the circle is {area}");
                        Console.WriteLine($"The perimeter of the circle is {perimeter}");
                        break;

                    case 2:
                        Console.Write("Enter the length of the rectangle: ");
                        double length = double.Parse(Console.ReadLine());

                        Console.Write("Enter the width of the rectangle: ");
                        double width = double.Parse(Console.ReadLine());

                        Rectangle rectangle = new Rectangle(length, width);

                        double areaRec = rectangle.getArea();
                        double perimeterRec = rectangle.getPerimeter();

                        Console.WriteLine($"The area of the rectangle is {areaRec}");
                        Console.WriteLine($"The perimeter of the rectangle is {perimeterRec}");
                        break;

                    case 3:
                        Console.WriteLine("Exit");
                        continueProgram = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please choose a number between 1 and 3.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }

    // Method to display the menu
    static void DisplayMenu()
    {
        Console.WriteLine("\nMENU");
        Console.WriteLine("[1] Circle");
        Console.WriteLine("[2] Rectangle");
        Console.WriteLine("[3] Exit");
    }
}
