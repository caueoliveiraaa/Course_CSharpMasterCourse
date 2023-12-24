// Variables: 
int x; // Declaration
x = 123; // Initialization
int y = 123; // Declaration + Initialization
int z = x + y; // Result of sum
int age = 21; // Whole integer
double height = 300.5; // FLoating numebr
bool alive = true; // Boolean
char symbol = '@'; // Single character
string name = "Smith"; // String of characters 
// Constants:
const double pi = 3.14159;  // Imutable variable
const string cpf = "444.555.999.666/22";

Console.Clear(); // Clear terminal output
// Display information with concatenation:
Console.WriteLine("X: " + x);
Console.WriteLine("Y: " + y);
Console.WriteLine("Z: " + z);
Console.WriteLine("Age: " + age);
Console.WriteLine("Height: " + height + "cm");
Console.WriteLine("Alive: " + alive);
Console.WriteLine("Symbol: " + symbol);
Console.WriteLine("Name: " + name);
Console.WriteLine("PI: " + pi);
Console.WriteLine("CPF: " + cpf);

Console.ReadKey();
