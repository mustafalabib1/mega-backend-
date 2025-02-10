internal class Program
{
	private static void Main(string[] args)
	{
		#region  Writing to Console 
		//Console.Title = "C# Fundamentals | Passionate Coders";
		//Console.ForegroundColor = ConsoleColor.Blue;
		//Console.Write("Hello");
		//Console.BackgroundColor = ConsoleColor.Yellow;
		//Console.Write(", World!");
		//Console.ForegroundColor = ConsoleColor.White;
		//Console.BackgroundColor = ConsoleColor.Black;
		//Console.ReadKey(); 
		#endregion

		#region Variables
		//string statementToPrint;
		//statementToPrint = "Hello, Passionate Coders!";

		//Console.WriteLine(statementToPrint);
		//Console.WriteLine(statementToPrint);
		//Console.WriteLine(statementToPrint);
		//Console.WriteLine(statementToPrint);
		//Console.WriteLine(statementToPrint); 
		#endregion

		#region Boolean 
		//bool isAlive = false;
		//Console.Write("IsAlive = ");

		//Console.WriteLine(isAlive);
		//isAlive = true;
		//Console.Write("IsAlive = ");
		//Console.WriteLine(isAlive);
		//isAlive = false;

		//bool boolean1 = false, boolean2 = false;

		////bool result1 = boolean1 | boolean2;//long circuit 
		////bool result2 = boolean1 || boolean2;//short circuit
		////bool result1 = boolean1 &boolean2;//long circuit 
		////bool result2 = boolean1 && boolean2;//short circuit
		//bool result1 = !boolean1 ;
		//bool result2 = !boolean2;
		//result1 = boolean1 ^ boolean2;
		//Console.Write("Result1 = ");

		//Console.WriteLine(result1);
		//Console.Write("Result2 = ");

		//Console.WriteLine(result2);
		#endregion

		#region Char 
		//Console.Write("Write any character then press ENTER: ");
		//// 1 -> 49 		A-> 65

		//// ASCII -> American Standard Code Information Interchange
		//int c1 = Console.Read();
		//int c2 = Console.Read();
		//int c3 = Console.Read();
		//int c4 = Console.Read();
		//int c5 = Console.Read();

		//Console.WriteLine(c1);
		//Console.WriteLine(c2);
		//Console.WriteLine(c3);
		//Console.WriteLine(c4);
		//Console.WriteLine(c5);

		//Console.WriteLine("Print ASCII for capital letters A to Z");
		//for (char c = 'A'; c <= 'Z'; c++)
		//{
		//	Console.Write((int)c + " ");
		//}
		//Console.WriteLine();

		//Console.WriteLine(" Print ASCII for small letters a to z");
		//for (char c = 'a'; c <= 'z'; c++)
		//{
		//	Console.Write((int)c + " ");
		//}
		//Console.WriteLine();

		//Console.WriteLine("Print ASCII for numbers 0 to 9");
		//for (char c = '1'; c <= '9'; c++)
		//{
		//Console.Write((int)c + " ");
		//}
		//Console.WriteLine();

		//bool isDigit = char.IsLetter('A');
		//Console.WriteLine(isDigit);

		//isDigit = char.IsLetter('1');
		//Console.WriteLine(isDigit);
		//isDigit = char.IsSymbol('1');
		//Console.WriteLine(isDigit);
		#endregion

		#region String Part 1
		//Console.Write("Hello\\t\\tWorld");

		//string hello = "Hello";
		//string world = " World!";
		//Console.Write(hello + world);

		//string hello = @"Hello\t\t\nWorld";
		//Console.Write(hello);

		//string name = "Mohammed";
		//Console.Write($"Hello {name}\nWelcome to our C# course!");

		#endregion

		#region String Part 2
		//string name = "";
		//Console.Write("Please enter your name: ");

		//name = Console.ReadLine();
		//Console.WriteLine(name.EndsWith("ed"));
		//Console.WriteLine(name.EndsWith("ED", StringComparison.OrdinalIgnoreCase));
		//Console.WriteLine(name.Contains("ed"));
		//Console.WriteLine(name.Contains("ED", StringComparison.OrdinalIgnoreCase));
		//Console.WriteLine(name.IndexOf("ed"));
		//Console.WriteLine(name.IndexOf("ED", StringComparison.OrdinalIgnoreCase));
		//Console.WriteLine(name.LastIndexOf("ED", StringComparison.OrdinalIgnoreCase));
		//Console.WriteLine(name.Replace("Labib", "Mohammed", StringComparison.OrdinalIgnoreCase));
		////Console.WriteLine($"Welcome {name}!");
		////Console.WriteLine($"Length = {name.Length}");
		////Console.WriteLine($"Upper Case: {name.ToUpper()}");
		////Console.WriteLine($"Lower Case: {name.ToLower()}");
		///

		//Console.Write("Enter the original string : ");
		//string original = Console.ReadLine();
		//Console.Write("Enter what you want to replace : ");
		//string requiredToBeReplaced = Console.ReadLine();
		//Console.Write("Enter What you want to replace it to : ");
		//string replace = Console.ReadLine();
		//string FinalResult = original.Replace(requiredToBeReplaced, replace);
		//Console.WriteLine(FinalResult);
		#endregion

		#region Numeric

		//// int
		//Console.WriteLine($"Int Memory Size: {sizeof(int)} bytes");
		//Console.WriteLine($"Int Min Value: {int.MinValue}");
		//Console.WriteLine($"Int Max Value: {int.MaxValue}");
		//Console.WriteLine("------------");

		//// uint
		//Console.WriteLine($"UInt Memory Size: {sizeof(uint)} bytes");
		//Console.WriteLine($"UInt Min Value: {uint.MinValue}");
		//Console.WriteLine($"UInt Max Value: {uint.MaxValue}");
		//Console.WriteLine("------------");

		//// short
		//Console.WriteLine($"Short Memory Size: {sizeof(short)} bytes");
		//Console.WriteLine($"Short Min Value: {short.MinValue}");
		//Console.WriteLine($"Short Max Value: {short.MaxValue}");
		//Console.WriteLine("------------");

		//// ushort
		//Console.WriteLine($"UShort Memory Size: {sizeof(ushort)} bytes");
		//Console.WriteLine($"UShort Min Value: {ushort.MinValue}");
		//Console.WriteLine($"UShort Max Value: {ushort.MaxValue}");
		//Console.WriteLine("------------");

		//// long
		//Console.WriteLine($"Long Memory Size: {sizeof(long)} bytes");
		//Console.WriteLine($"Long Min Value: {long.MinValue}");
		//Console.WriteLine($"Long Max Value: {long.MaxValue}");
		//Console.WriteLine("------------");

		//// ulong
		//Console.WriteLine($"ULong Memory Size: {sizeof(ulong)} bytes");
		//Console.WriteLine($"ULong Min Value: {ulong.MinValue}");
		//Console.WriteLine($"ULong Max Value: {ulong.MaxValue}");
		//Console.WriteLine("------------");

		//// byte
		//Console.WriteLine($"Byte Memory Size: {sizeof(byte)} bytes");
		//Console.WriteLine($"Byte Min Value: {byte.MinValue}");
		//Console.WriteLine($"Byte Max Value: {byte.MaxValue}");
		//Console.WriteLine("------------");

		//// sbyte
		//Console.WriteLine($"SByte Memory Size: {sizeof(sbyte)} bytes");
		//Console.WriteLine($"SByte Min Value: {sbyte.MinValue}");
		//Console.WriteLine($"SByte Max Value: {sbyte.MaxValue}");
		//Console.WriteLine("------------");

		//// float
		//Console.WriteLine($"Float Memory Size: {sizeof(float)} bytes");
		//Console.WriteLine($"Float Min Value: {float.MinValue}");
		//Console.WriteLine($"Float Max Value: {float.MaxValue}");
		//Console.WriteLine("------------");

		//// double
		//Console.WriteLine($"Double Memory Size: {sizeof(double)} bytes");
		//Console.WriteLine($"Double Min Value: {double.MinValue}");
		//Console.WriteLine($"Double Max Value: {double.MaxValue}");
		//Console.WriteLine("------------");

		//// decimal
		//Console.WriteLine($"Decimal Memory Size: {sizeof(decimal)} bytes");
		//Console.WriteLine($"Decimal Min Value: {decimal.MinValue}");
		//Console.WriteLine($"Decimal Max Value: {decimal.MaxValue}");
		//Console.WriteLine("------------");

		//// char
		//Console.WriteLine($"Char Memory Size: {sizeof(char)} bytes");
		//Console.WriteLine($"Char Min Value: {(int)char.MinValue}");
		//Console.WriteLine($"Char Max Value: {(int)char.MaxValue}");
		//Console.WriteLine("------------");

		//// bool
		//Console.WriteLine($"Bool Memory Size: {sizeof(bool)} bytes");
		//Console.WriteLine($"Bool Min Value: {false}"); // bool only has true/false
		//Console.WriteLine($"Bool Max Value: {true}");
		//Console.WriteLine("------------");
		//int int1 = 0;
		//int int2 = 50;
		//int int3 = -50;
		//// u -> unsigned
		//uint uint1 = 0;
		//uint uint2 = 50;
		//uint uint3 = -50;  // NOT ALLOWED !!

		#endregion

		#region  Arithmetic Operators
		//int x = 25;
		//int y = 10;
		//Console.WriteLine($"{x} + {y} = {x + y}");
		//Console.WriteLine($"{x} - {y} = {x - y}");
		//Console.WriteLine($"{x} * {y} = {x * y}");
		//Console.WriteLine($"{x} / {y} = {(double)x / y}");
		//Console.WriteLine($"{x} % {y} = {x % y}");
		#endregion

		#region Operator Precedence
		//Console.WriteLine($"5 + 10 - 5 = {5 + 10 - 5}"); // 10 - Addition and subtraction have the same precedence, so they are evaluated left to right.
		//Console.WriteLine($"50 - 10 + 3 = {50 - 10 + 3}"); // 43 - Addition and subtraction have the same precedence, so they are evaluated left to right.
		//Console.WriteLine($"50 * 10 - 4 = {50 * 10 - 4}"); // 496 - Multiplication has higher precedence than subtraction, so multiplication is performed first.
		//Console.WriteLine($"50 / 10 + 2 = {50 / 10 + 2}"); // 7 - Division has higher precedence than addition, so division is performed first.

		//Console.WriteLine($"50 * (10 - 4) = {50 * (10 - 4)}"); // 300 - parentheses have the highest precedence, so the subtraction inside the parentheses is performed first.
		//Console.WriteLine($"60 / (10 + 2) = {60 / (10 + 2)}"); // 5 - parentheses have the highest precedence, so the addition inside the parentheses is performed first.
		#endregion

		#region Assignment Operators
		//// Simple assignment operator (=)
		//int a = 10; // Assigns the value 10 to the variable 'a'
		//Console.WriteLine($"Initial value of a: {a}");

		//// Addition assignment operator (+=)
		//a += 5; // Equivalent to: a = a + 5; (Adds 5 to 'a' and assigns the result back to 'a')
		//Console.WriteLine($"After a += 5: {a}");

		//// Subtraction assignment operator (-=)
		//a -= 3; // Equivalent to: a = a - 3; (Subtracts 3 from 'a' and assigns the result back to 'a')
		//Console.WriteLine($"After a -= 3: {a}");

		//// Multiplication assignment operator (*=)
		//a *= 2; // Equivalent to: a = a * 2; (Multiplies 'a' by 2 and assigns the result back to 'a')
		//Console.WriteLine($"After a *= 2: {a}");

		//// Division assignment operator (/=)
		//a /= 4; // Equivalent to: a = a / 4; (Divides 'a' by 4 and assigns the result back to 'a')
		//Console.WriteLine($"After a /= 4: {a}");

		//// Modulus assignment operator (%=)
		//a %= 3; // Equivalent to: a = a % 3; (Computes the remainder of 'a' divided by 3 and assigns it back to 'a')
		//Console.WriteLine($"After a %= 3: {a}");

		//// Left shift assignment operator (<<=)
		//a <<= 2; // Equivalent to: a = a << 2; (Shifts the bits of 'a' two places to the left and assigns the result back to 'a')
		//Console.WriteLine($"After a <<= 2: {a}");

		//// Right shift assignment operator (>>=)
		//a >>= 1; // Equivalent to: a = a >> 1; (Shifts the bits of 'a' one place to the right and assigns the result back to 'a')
		//Console.WriteLine($"After a >>= 1: {a}");

		//// Bitwise AND assignment operator (&=)
		//a &= 3; // Equivalent to: a = a & 3; (Performs a bitwise AND operation between 'a' and 3, then assigns the result back to 'a')
		//Console.WriteLine($"After a &= 3: {a}");

		//// Bitwise OR assignment operator (|=)
		//a |= 2; // Equivalent to: a = a | 2; (Performs a bitwise OR operation between 'a' and 2, then assigns the result back to 'a')
		//Console.WriteLine($"After a |= 2: {a}");

		//// Bitwise XOR assignment operator (^=)
		//a ^= 1; // Equivalent to: a = a ^ 1; (Performs a bitwise XOR operation between 'a' and 1, then assigns the result back to 'a')
		//Console.WriteLine($"After a ^= 1: {a}");

		#endregion

		#region  Increment & Decrement Operators
		//int x = 5;
		//int y;

		//// Pre-Increment
		//y = ++x; // x is incremented to 6, then assigned to y
		//Console.WriteLine($"Pre-Increment: x = {x}, y = {y}");

		//// Post-Increment
		//y = x++; // y is assigned the current value of x (6), then x is incremented to 7
		//Console.WriteLine($"Post-Increment: x = {x}, y = {y}");

		//// Pre-Decrement
		//y = --x; // x is decremented to 6, then assigned to y
		//Console.WriteLine($"Pre-Decrement: x = {x}, y = {y}");

		//// Post-Decrement
		//y = x--; // y is assigned the current value of x (6), then x is decremented to 5
		//Console.WriteLine($"Post-Decrement: x = {x}, y = {y}");

		//// Operator Precedence Example
		//int a = 10;
		//int b = 5;
		//int result = ++a * b-- + a / b; // Evaluate based on precedence
		//Console.WriteLine($"Operator Precedence Example: result = {result}");
		#endregion

		#region Comparison Operators
		//int x = 5;

		//Console.WriteLine($"x == 5 ? {x == 5}"); // true
		//Console.WriteLine($"x == 10 ? {x == 10}"); // false

		//Console.WriteLine($"x != 5 ? {x != 5}"); // false
		//Console.WriteLine($"x != 10 ? {x != 10}"); // true

		//Console.WriteLine($"x > 5 ? {x > 5}"); // false
		//Console.WriteLine($"x > 3 ? {x > 3}"); // true

		//Console.WriteLine($"x < 5 ? {x < 5}"); // false
		//Console.WriteLine($"x < 10 ? {x < 10}"); // true

		//Console.WriteLine($"x >= 5 ? {x >= 5}"); // true
		//Console.WriteLine($"x >= 10 ? {x >= 10}"); // false

		//Console.WriteLine($"x <= 5 ? {x <= 5}"); // true
		//Console.WriteLine($"x <= 2 ? {x <= 2}"); // false
		#endregion

		#region Parse Strings
		//Console.Write("Enter your birth year: ");
		//string year = Console.ReadLine();

		//double intYear = double.Parse(year);
		//Console.WriteLine($"Your age until {DateTime.Now.Year} = { DateTime.Now.Year - intYear}");
		#endregion

		#region Control Flow
		//Console.Write("Please enter a number: ");
		//string number = Console.ReadLine();
		//int parsedNumber = int.Parse(number);
		//int remainder = parsedNumber % 2;
		//if (remainder == 1)
		//{
		//	Console.WriteLine($"{number} is odd.");
		//}
		//else if (parsedNumber == 0)
		//{
		//	Console.WriteLine("Zero is neither odd nor even.");
		//}
		//else
		//{
		//	Console.WriteLine($"{number} is even.");
		//}
		#endregion

		#region debugging 
		/* Debugging in Visual Studio (VS) helps you find and fix errors in your code. 
		 * You set breakpoints to pause execution, then step through code line by line (F10, F11).
		 * VS shows you variable values in windows like Locals and Watch.  Start debugging with F5. 
		 * Edit and continue lets you change code while debugging.
		 * Use these tools to understand your code's behavior and squash bugs!
		 */
		#endregion

		#region Arrays
		//// Declare and initialize an array
		//int[] numbers = { 5, 3, 9, 1, 4 };

		//// Access an element
		//Console.WriteLine($"Element at index 2: {numbers[2]}"); // Output: 9

		//// Sort the array
		//Array.Sort(numbers);
		//Console.WriteLine("Sorted Array:");
		//foreach (var num in numbers)
		//{
		//	Console.Write(num + " "); // Output: 1 3 4 5 9
		//}
		//Console.WriteLine();

		//// Copy the array
		//int[] copiedArray = new int[numbers.Length];
		//Array.Copy(numbers, copiedArray, numbers.Length);
		//// or we can use clone directly 
		////int[] copiedArray = (int[])numbers.Clone();
		////Console.WriteLine($"{numbers.GetHashCode()}\t{copiedArray.GetHashCode()}");
		//Console.WriteLine("Copied Array:");
		//foreach (int num in copiedArray)
		//{
		//	Console.Write(num + " "); // Output: 1 3 4 5 9
		//}
		//Console.WriteLine();
		#endregion

		#region  For Loop
		//int[] numbers = { 50, 60, 70, 80, 90, 100, 110, 120 };
		//for (int i = 0; i < numbers.Length; i += 2)
		//{
		//	Console.WriteLine(numbers[i]);
		//}

		////int x = 50;
		////for (int i = 0; i < 10; i++)
		////{
		////    Console.WriteLine(x);
		////    x += 5;
		////}
		//===================================Assignment=============================================
		//bool again=true;
		//Console.WriteLine("Enter 5 numbers in same row seperate between them by speace:");
		//while(again) 
		//{
		//	again=false;
		//	try
		//	{
		//		int[] inputs = Console.ReadLine().Split().Select(a => int.Parse(a)).ToArray();
		//		Array.Sort(inputs);
		//		if (inputs.Length != 5)
		//		{
		//			again = true;
		//			Console.WriteLine("Please enter 5 numbers in same row seperate between them by speace:");
		//			continue;
		//		}
		//		foreach (var item in inputs)
		//		{
		//			Console.Write($"{item} ");
		//		}
		//	}
		//	catch
		//	{
		//		Console.WriteLine("pleas input valid date");
		//		again = true;
		//	}
		//}
		#endregion
	}
}