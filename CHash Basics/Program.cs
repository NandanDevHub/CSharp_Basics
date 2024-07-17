// See https://aka.ms/new-console-template for more
//

//Task 1 Hello World
// ----------------------------------
using CHash_Basics;

Console.WriteLine("Hello, World! \n");
// Task 2 Different Data Types
//----------------------------------

int operation; // Declartion of int variable
operation = 2 + 5 * 4; // Initializing the calculation
Console.WriteLine("Operation is = " + operation);
Console.WriteLine("\n");


// Task 3 Arithmatic Operations
// ---------------------------------
int dividingInteger = 25 / 2; //integer division
double dividingFloats = 25.00 / 2.00;// float division


int modulo = 25 % 2; //Remainder

int x = 0;
x++;
Console.WriteLine("The New value of x is = " + x);

// Similarly x-- will subtract -1
// ++ means +1
// -- means -1

Console.WriteLine("\n");


// Task 4 C# Characters
// -------------------------------

char myFirstInitial = 'N';
char myLastInitial = 'P';

char hexCodeFirst = '\u004E';
char hecCodeLast = '\u0050';
char tab = '\t';

Console.Write("My Normal First is" + tab + myFirstInitial);
Console.WriteLine("My Normallast is" + tab + myLastInitial);

Console.Write("My hex First is" + tab + hexCodeFirst);
Console.WriteLine("My hex Last is" + tab + hecCodeLast);
Console.WriteLine("\n");


// Task 5 Accpting User Inputs
// --------------------------------
string firstName = "";
string lastName = "";
int age;

Console.WriteLine("Enter your first name: ");
firstName = Console.ReadLine();

Console.WriteLine("Enter your last Name: ");
lastName = Console.ReadLine();

Console.WriteLine("Enter the Age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(firstName);
Console.WriteLine(lastName);
Console.WriteLine("The Age is" + age + "and Last Name is " + lastName);
Console.WriteLine("\n");

// Task 6 Boolean Logic
// ------------------------------

bool isRainy = false;
bool isSunny = true;

Console.WriteLine("Is it Raining " + isRainy);
Console.WriteLine("Is it Sunny"  + isSunny);

bool isBigger = 10 > 3;
Console.WriteLine("Is Case is Bigger"  + isBigger);

bool isSmaller = 10 < 3;
Console.WriteLine("Is Case 2 is Smaller " + isSmaller);

Console.WriteLine("\n WELCOME TO BARZILLA CLUB");
Console.WriteLine("------------------------------");

if (age > 21)
{
    Console.WriteLine("Welcome to the Club ");
}
else
{
    Console.WriteLine("Sorry! See you in few years");
}

// Task 7 Looping in C#
// ------------------------------

int z = -4;
while (z<0)
{
    Console.WriteLine("New Year Begins in " + z);
    z++;
}


// Task 8 Methods in C#
// ----------------------------

LearnMethod learnMethod = new LearnMethod();
learnMethod.ExecuteMethods();

