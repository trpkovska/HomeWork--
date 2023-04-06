// 1. Write a C# Sharp program that takes two numbers as user input and perform an operation on them and displays the result of that operation.

int x, y;
char operation;
Console.WriteLine("Input first number:");
x = int.Parse(Console.ReadLine());
Console.WriteLine("Input operation:");
operation = char.Parse(Console.ReadLine());
Console.WriteLine("Input second number:");
y = int.Parse(Console.ReadLine());

if (operation == '+')
    Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
else if (operation == '-')
    Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
else if (operation == '*')
    Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
else if (operation == '/')
    Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
else Console.WriteLine("Wrong Character");



//2. Write a C# Sharp program that takes two strings as user input and perform concatenation on them with "%" sign and displays the result of that operation.

string string1, string2;
Console.WriteLine("input first string");
string1 = Console.ReadLine();
Console.WriteLine("input second string");
string2 = Console.ReadLine();
Console.WriteLine($"Concatenation result:{string1}%{string2}");









// 3.Write a C# Sharp program that takes two numbers as user input and compares them if they are equal. 
// If they are equal write on the console "Equal".
//If they are not equal write on the console "Not Equal".

int a, b;
Console.WriteLine("input first number");
a = int.Parse(Console.ReadLine());
Console.WriteLine("input second number");
b = int.Parse(Console.ReadLine());
if (a == b)
{
    Console.WriteLine("Equal");
}
else
{
    Console.WriteLine("Not equal");
}




