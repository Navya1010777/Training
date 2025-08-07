// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");

//VariableDeclarationDemo();

//PersonDetails(); 

//Console.WriteLine(CalculatorDemo());

//Loops Demo
//ForLoopDemo();
//WhileLoopDemo();
//DoWhileDemo();

//Sample problem
//Take i/p student name, marks for 5 subjects and give total marks and avg marks
Console.WriteLine("Enter student name");
string name = Console.ReadLine();
int[] marksArray = new int[5];
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Enter Subject {i} marks:");
    marksArray[i-1] = Convert.ToInt32(Console.ReadLine());
}

int total = TotalMarks(marksArray);
float avg = AverageMarks(marksArray);

Console.WriteLine($"Hello {name}!!, your total marks is {total} and your average marks is {avg}");

static int TotalMarks(int[] marks)
{
    int i = 0;
    int total = 0;
    while (i < marks.Length)
    {
        total += marks[i];
        i++;
    }
    return total;
}

static float AverageMarks(int[] marks)
{
    int n = marks.Length;
    float total = 0;
    for (int i = 0; i < n; i++)
    {
        total += marks[i];
    }

    return total / n;
}
 static void ForLoopDemo() { 
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
}

static void WhileLoopDemo() {
    int i = 1;
    while (i <= 11)
    {
        int j = (11 - i)/2;
        while (j != 0) { Console.Write(" "); j--; }
        int k = 0;
        while (k <= i)
        {
            Console.Write("*");
            k++;
        }
        j = 11 - i;
        while (j != 0)
        {
            Console.Write(" ");
            j--;
        }
        Console.WriteLine();
        i++;
    }
}

static void DoWhileDemo()
{
    int i = 6;
    do
    {
        Console.WriteLine($"This is the {i}th iteration");
        i++;
    } while (i < 6);
}

static string CalculatorDemo()
{
    Calculator calculator = new Calculator();
    Console.WriteLine("Enter first number");
    int firstNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter second number");
    int secondNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter operator");
    string operation = Console.ReadLine();
    int result = 0;

    switch (operation)
    {
        case "+":
            result = calculator.Add(firstNumber, secondNumber);
            break;
        case "-":
            result = calculator.Subtract(firstNumber, secondNumber);
            break;
        case "*":
            result = calculator.Multiply(firstNumber, secondNumber);
            break;
        case "/":
            try
            {
                result = calculator.Divide(firstNumber, secondNumber);
            }
            catch (DivideByZeroException d)
            {
                //Console.WriteLine(d.Message);
                //exit the program if division by zero attempt is made
                return d.Message;
            }
            break;
        default: //Console.WriteLine("Select a valid operator");
            return $"Invalid operation";

    }
    //Console.WriteLine($"Result is {result}");
    //return "Result is "+result+"dfd"+firstNumber+" "+secondNumber;
    string res = $"Result of {firstNumber} {operation} {secondNumber} is {result}";
    return res;
}
static void VariableDeclarationDemo()
{
    //Variable Declaration
    int number = 10;
    string greeting = "Hello, C#";
    Console.WriteLine($"Number: {number} and {greeting}");

    //previous type of variable incorporation
    Console.WriteLine("Number: {0} and {1}", number, greeting);
}

static void PersonDetails()
{
    Console.WriteLine("Please enter your name");
    string name = Console.ReadLine();

    Console.WriteLine("Please enter your city");
    string city = Console.ReadLine();

    Console.WriteLine("Please enter your age");
    int age = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Hello {name}, you are from {city} and you are {age} years old");
}




