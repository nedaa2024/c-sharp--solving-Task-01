
//******** LOOK AT THE README.md to see result image  *********  
// -------------------Task 01 c#-------------------- 



//1-Write a program that enters the diameter of the circle from the keyboard and prints the circumference of the circle.

Console.WriteLine("We Need to Calc The circumference of the circle so , PLZ ENTER THE DIMETER OF THE CIRCLE : ");
int diameter = Convert.ToInt32(Console.ReadLine());
double Result = Math.PI * diameter;
Console.WriteLine($"circumference of the circle is : {Result} ");


Console.WriteLine();
Console.WriteLine("=====================================================================");
Console.WriteLine();





//2 - •Write a program that inputs time and distance from the keyboard and print the speed in meters per hour and kilometers per hour.


Console.WriteLine("We need to calculate the speed in m/h and km/h.");
Console.WriteLine("Please enter the time in hours and the distance in meters:");
Console.Write("Time in hours: ");
int hours = Convert.ToInt32(Console.ReadLine());
Console.Write("Distance in meters: ");
double distance = Convert.ToDouble(Console.ReadLine());
double distance_In_Kilometers = distance / 1000;
double speed_in_meters_per_hour = distance / hours;
double speed_in_kilometers_per_hour = distance_In_Kilometers / hours;
Console.WriteLine($"Speed in meters per hour: {speed_in_meters_per_hour}");
Console.WriteLine($"Speed in kilometers per hour: {speed_in_kilometers_per_hour}");





Console.WriteLine();
Console.WriteLine("=====================================================================");
Console.WriteLine();


// 3- What are the differences between Post Increment and Pre-Increment operators?

/*Post-Increment Operator : Increments the variable after its current value is used.
 the result of post increment is  >> The original value is used first, then the variable is incremented.*/
// Post Increment Operator example
int num = 5;
int y = num++;
Console.WriteLine($"Post-Increment Operator:");
Console.WriteLine($"Initial num = 5");
Console.WriteLine($"After post-increment: num = {num}, y = {y}");// num = 6, y = 5 


/*Pre-Increment Operator : Increments the variable before its new value is used. 
  the result of pre increment is >> The variable is incremented first, then the new value is used.
 */
// Pre Increment Operator example

int num2 = 5;
int y2 = ++num2;
Console.WriteLine($"Pre-Increment Operator:");
Console.WriteLine($"Initial num2 = 5");
Console.WriteLine($"After pre-increment: num2 = {num2}, y2 = {y2}"); // num2 = 6, y2 = 6

Console.WriteLine();
Console.WriteLine("=====================================================================");
Console.WriteLine();





// 4- Use Math.Round to round a double number to the nearest integer

Console.WriteLine("Please enter the double number:");
double number = Convert.ToDouble(Console.ReadLine());

int rounded_number = Convert.ToInt32(Math.Round(number));

Console.WriteLine("Rounded number is: " + rounded_number);










Console.WriteLine();
Console.WriteLine("=====================================================================");
Console.WriteLine();






// 5-Use Math.Pow to calculate the result of baseNumber raised to the power of exponent

Console.WriteLine("We need to calculate the result of baseNumber raised to the power of exponent.");

Console.Write("Enter the base number: ");
double base_number = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the exponent number: ");
double exponent_number = Convert.ToDouble(Console.ReadLine());

double result_number = Math.Pow(base_number, exponent_number);

Console.WriteLine($"Result: {result_number}");







Console.WriteLine();
Console.WriteLine("=====================================================================");
Console.WriteLine();







// 6-Write a program to check whether a year is a leap or not.


Console.Write("Please enter a year: ");

int year = Convert.ToInt32(Console.ReadLine());

bool is_Leap_Year = false;

if (year % 2 != 0)
{ is_Leap_Year = false; }

else
{

    if (year % 100 == 0)

    {
        if (year % 400 == 0)
        { is_Leap_Year = true; }


        else { is_Leap_Year = false; }
    }


    else { is_Leap_Year = (year % 4 == 0); }
}
if (is_Leap_Year)
{ Console.WriteLine($"{year} is a leap year."); }

else { Console.WriteLine($"{year} is not a leap year."); }





Console.WriteLine();
Console.WriteLine("=====================================================================");
Console.WriteLine();




//7- Write program to Check whether an alphabet is lowercase or uppercase

Console.Write("Please enter a character: ");
char ch = Convert.ToChar(Console.ReadLine());

string result = char.IsUpper(ch)
                ? $"{ch} is an uppercase letter."
                : char.IsLower(ch)
                ? $"{ch} is a lowercase letter."
                : $"{ch} is not an alphabet character.";

Console.WriteLine(result);





Console.WriteLine();
Console.WriteLine("=====================================================================");
Console.WriteLine();





//8-Write a program to create a simple calculator (*/+-) using switch statement.

Console.WriteLine("Hello in my calculator ");
Console.WriteLine("Enter Number one ");
double num01 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter Number two ");
double num02 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("please select any operator of them : (+ - * / )");
char ch_operator = Convert.ToChar(Console.ReadLine());

switch (ch_operator)
{

    case '+':
        {
            Console.WriteLine($"{num01} + {num02} = {num01 + num02}");
            break;
        }

    case '-':
        {
            Console.WriteLine($"{num01} - {num02} = {num01 - num02}");
            break;
        }

    case '*':
        {
            Console.WriteLine($"{num01} * {num02} = {num01 * num02}");
            break;
        }

    case '/':
        {
            if (num02 != 0)
            { Console.WriteLine($"{num01} / {num02} = {num01 / num02}"); }

            else { Console.WriteLine("Error: Cannot divide by zero."); }

            break;
        }


    default: { Console.WriteLine("Invalid operator."); break; }







}




Console.WriteLine();
Console.WriteLine("=====================================================================");
Console.WriteLine();







//9-Write a program to take 3 numbers from the keyboard and find the maximum number using ternary operator.

Console.WriteLine("Enter any three numbers :");

double number01 = Convert.ToDouble(Console.ReadLine());

double number02 = Convert.ToDouble(Console.ReadLine());

double number03 = Convert.ToDouble(Console.ReadLine());

double max = number01 > number02
    ? (number01 > number03 ? number01 : number03)
    : (number02 > number03 ? number02 : number03);

Console.WriteLine($"The maximum number is: {max}");










Console.WriteLine();
Console.WriteLine("=====================================================================");
Console.WriteLine();








//10-Write a program to takes a number from the keyboard and check if  the number is odd or even using Ternary operator.



Console.WriteLine("Enter any number to check if it is odd or even: :");

int numb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(numb % 2 == 0 ? "This is an even number" : "This is an odd number");










