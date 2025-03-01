using System.Collections;
using System.Collections.Generic;
using System.Text;

internal class Program
{
	#region 26- Methods - Part 1
	static void CalculateAverage(int[] numbers)
	{
		int sum = 0;
		foreach (int number in numbers)
		{
			sum += number;
		}

		double average = (double)sum / numbers.Length; // Explicitly cast to double
		Console.WriteLine($"Average = {average}");
	}
	#endregion

	#region 27- Methods - Part 2
	static double CalculateAverage(int[] numbers, bool printAverageToConsole = false, bool printSumToConsole = false)
	{
		int sum = 0;
		foreach (int number in numbers)
		{
			sum += number;
		}

		double average = (double)sum / numbers.Length; // Explicit cast to double

		if (printSumToConsole)
		{
			Console.WriteLine("Sum = " + sum);
		}

		if (printAverageToConsole == true)
		{
			Console.WriteLine($"Average = {average}");
		}

		return average;
	}
	#endregion

	#region 30- Training: Palindrome Words
	// Function to check if a word is a palindrome
	public static bool IsPalindrome(string word)
	{
		// Remove spaces and convert to lowercase for case-insensitive comparison
		word = word.Replace(" ", "").ToLower();

		// Reverse the word
		char[] charArray = word.ToCharArray();
		Array.Reverse(charArray);
		string reversedWord = new string(charArray);

		// Compare the original word with the reversed word
		return word == reversedWord;
	}
	#endregion

	#region 47- Enums
	public enum ConsoleColorOption
	{
		Black,
		Blue,
		Cyan,
		Gray,
		Green,
		Magenta,
		Red,
		White,
		Yellow
	}

	#endregion

	#region  48- Flags Enums
	[Flags]
	public enum FileAccess
	{
		None = 0,
		Read = 1,
		Write = 2,
		Execute = 4,
		ReadWrite = Read | Write,
		All = Read | Write | Execute
	}
	#endregion

	#region 59- Training: Password Manager
	private static readonly Dictionary<string, string> _passwordEntries = new ();
	#endregion
	private static void Main(string[] args)
	{
		#region 21- Ternary Operator
		//for (int i = 1; i <= 9; i++)
		//{
		//	string statement = i % 2 == 0 ? $"{i} is Even" : $"{i} is Odd";

		//	//if (i % 2 == 0)
		//	//{
		//	//    statement = $"{i} is Even";
		//	//}
		//	//else
		//	//{
		//	//    statement = $"{i} is Odd";
		//	//}

		//	Console.WriteLine(statement);
		//}		
		#endregion

		#region 22- Foreach Loop
		//char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

		//foreach (char digit in numbers)
		//{
		//	Console.WriteLine($"{digit} = {(int)digit}");
		//}

		////for (int i = 0; i < numbers.Length; i++)
		////{
		////    Console.WriteLine($"{numbers[i]} = {(int)numbers[i]}");
		////}
		#endregion

		#region 23- For & Foreach Training
		//// first practice
		//Console.Write("Enter array number of items: ");
		//int arraySize = int.Parse(Console.ReadLine());

		//int[] numbers = new int[arraySize];
		//for (int i = 0; i < arraySize; i++)
		//{
		//	Console.Write($"Enter array item #{i + 1}: ");
		//	numbers[i] = int.Parse(Console.ReadLine());
		//}

		//int[] reversedNumbers = new int[arraySize];
		//for (int i = arraySize - 1; i >= 0; i--)
		//{
		//	reversedNumbers[arraySize - i - 1] = numbers[i];
		//}

		//foreach (int number in numbers)
		//{
		//	Console.WriteLine(number);
		//}

		//Console.WriteLine("------------------");

		//foreach (int number in reversedNumbers)
		//{
		//	Console.WriteLine(number);
		//}

		//// second practice 
		//Console.Write("Enter array number of items: ");
		//int arraySize = int.Parse(Console.ReadLine());

		//int[] numbers = new int[arraySize];
		//for (int i = 0; i < arraySize; i++)
		//{
		//	Console.Write($"Enter array item #{i + 1}: ");
		//	numbers[i] = int.Parse(Console.ReadLine());
		//}

		//int sum = 0;
		//foreach (int number in numbers)
		//{
		//	sum += number;
		//}

		//double average = (double)sum / arraySize; // Explicitly cast sum to double
		//Console.WriteLine($"Average = {average}");

		#endregion

		#region  24- Do & While Loops

		//while (true)
		//{
		//	Console.Write("Enter any string to capitalize: ");
		//	string input = Console.ReadLine();

		//	if (input != "exit")
		//		Console.WriteLine(input.ToUpper());
		//	else
		//		break;
		//}

		//int x = 11;
		//while (x <= 10)
		//{
		//    Console.WriteLine(x++);
		//}

		//int x = 1; // Declare and initialize x (you can choose any starting value)

		//do
		//{
		//	Console.WriteLine(x++);
		//} while (x <= 10);

		#endregion

		#region  25- Switch Statement
		//while (true)
		//{
		//	Console.Write("Please enter a string: ");
		//	string input = Console.ReadLine();

		//	Console.WriteLine("Please select an option:");
		//	Console.WriteLine("1. Convert to capital");
		//	Console.WriteLine("2. Convert to lower");
		//	Console.WriteLine("3. Print string length");

		//	string selectedOption = Console.ReadLine();
		//	switch (selectedOption)
		//	{
		//		case "1":
		//			Console.WriteLine(input.ToUpper());
		//			break;
		//		case "2":
		//			Console.WriteLine(input.ToLower());
		//			break;
		//		case "3":
		//			Console.WriteLine(input.Length);
		//			break;
		//		default:
		//			Console.WriteLine("Invalid option !");
		//			break;
		//	}
		//	//if (selectedOption == "1")
		//	//{
		//	//	Console.WriteLine(input.ToUpper());
		//	//}
		//	//else if (selectedOption == "2")
		//	//{
		//	//	Console.WriteLine(input.ToLower());
		//	//}
		//	//else if (selectedOption == "3")
		//	//{
		//	//	Console.WriteLine(input.Length); // Corrected from input.Leng to input.Length
		//	//}
		//	//else
		//	//	Console.WriteLine("Invalid option !");
		//}
		#endregion

		#region 26- Methods - Part 1

		//int[] numbers = { 1, 2, 3, 4, 5 };
		//CalculateAverage(numbers);

		//numbers = new int[] { 10, 20, 30, 40, 50 };
		//CalculateAverage(numbers);		
		#endregion

		#region 27- Methods - Part 2
		//int[] numbers = { 1, 2, 3, 4, 5 };
		//CalculateAverage(numbers, printSumToConsole: true);

		//numbers = new int[] { 10, 20, 30, 40, 50 };
		//CalculateAverage(numbers, true);
		#endregion

		#region 28- Comments
		// This is a single line comment

		/* This is a multi-line
		comment. It can span multiple lines. */

		// TODO: Implement a function to save data to the database

		/// <summary>
		/// This method calculates the average of an array of integers.
		/// </summary>
		/// <param name="numbers">The array of integers to calculate the average of.</param>
		/// <returns>The average of the integers in the array.</returns>
		//public static double CalculateAverage(int[] numbers)
		//{
		//double average = 0;
		//foreach (int number in numbers) 
		//{ 
		//	average += number;
		//}
		//average = (double)average / numbers.Length;
		//return average;
		//}
		#endregion

		#region 29- Training: Array Findings
		//// 1. Ask the user to enter the number of items in an integer array
		//Console.Write("Enter the number of items in the array: ");
		//int arraySize = int.Parse(Console.ReadLine());

		//// 2. Ask the user to enter the items of this array
		//int[] numbers = new int[arraySize];
		//for (int i = 0; i < arraySize; i++)
		//{
		//	Console.Write($"Enter item {i + 1}: ");
		//	numbers[i] = int.Parse(Console.ReadLine());
		//}

		//// 3. Find the smallest number in the array
		//int smallest = numbers[0];
		//for (int i = 1; i < arraySize; i++)
		//{
		//	if (numbers[i] < smallest)
		//	{
		//		smallest = numbers[i];
		//	}
		//}
		//Console.WriteLine($"Smallest number: {smallest}");

		//// 4. Find the greatest number in the array
		//int greatest = numbers[0];
		//for (int i = 1; i < arraySize; i++)
		//{
		//	if (numbers[i] > greatest)
		//	{
		//		greatest = numbers[i];
		//	}
		//}
		//Console.WriteLine($"Greatest number: {greatest}");

		//// 5. Calculate the average of the array
		//int sum = 0;
		//foreach (int number in numbers)
		//{
		//	sum += number;
		//}
		//double average = (double)sum / arraySize;
		//Console.WriteLine($"Average: {average}");
		#endregion

		#region 30- Training: Palindrome Words
		//Console.Write("Enter any word: ");
		//string word = Console.ReadLine();

		//// 2. Check if the word is 'Palindrome' or not
		//if (IsPalindrome(word))
		//{
		//	Console.WriteLine($"{word} is a palindrome.");
		//}
		//else
		//{
		//	Console.WriteLine($"{word} is not a palindrome.");
		//}
		#endregion

		#region 31- Value Types & Reference Types
		//int num1 = 10;
		//int num2 = num1; // num2 gets a copy of num1's value

		//num2 = 20; // Changing num2 doesn't affect num1

		//Console.WriteLine($"num1: {num1}"); // Output: num1: 10
		//Console.WriteLine($"num2: {num2}"); // Output: num2: 20
		/////////////////////////////////////////////////////////////////////////////
		//int[] array1 = { 1, 2, 3 };
		//int[] array2 = array1; // array2 points to the same array as array1

		//array2[0] = 10; // Changing array2 also changes array1

		//Console.WriteLine($"array1[0]: {array1[0]}"); // Output: array1[0]: 10
		//Console.WriteLine($"array2[0]: {array2[0]}"); // Output: array2[0]: 10
		#endregion

		#region 32- Type Casting
		//int myInt = 10;
		//double myDouble = myInt; // Implicit casting from int to double

		//Console.WriteLine(myDouble); // Output: 10.0
		///////////////////////////////////////////////////////////
		// myDouble = 10.75;
		// myInt = (int)myDouble; // Explicit casting from double to int

		//Console.WriteLine(myInt); // Output: 10 (decimal part is truncated)
		// ///////////////////////////////////////////////////////////////////////////

		//string myString = "123";
		// myInt = Convert.ToInt32(myString);

		// myString = "456";
		// myInt = int.Parse(myString);
		#endregion

		#region 33- String Formatting
		//double salary = 10000;
		//string str = "Hello My Name Is: {0,5}{1,12}";

		//str = string.Format(str, "Mustafa", "Labib");
		//Console.WriteLine(str);

		//double salary = 10000.5;
		//string str = "Your Salary is {0:c2}";

		//str = string.Format(str, salary);
		//Console.WriteLine(str);

		//double salary = 10000.5;
		//string str = "Your Salary is {0:0.000000}";

		//str = string.Format(str, salary);
		//Console.WriteLine(str);

		#endregion

		#region 34- String Split & Join
		//// Example 1: Splitting a string by spaces
		//string sentence = "This is a sentence.";
		//string[] words = sentence.Split(' ');

		//foreach (string word in words)
		//{
		//	Console.WriteLine(word);
		//}

		//// Example 2: Splitting a string by commas
		//string data = "apple,banana,cherry";
		//string[] fruits = data.Split(',');

		//foreach (string fruit in fruits)
		//{
		//	Console.WriteLine(fruit);
		//}

		//// Example 3: Splitting a string by a delimiter and limiting the number of splits
		//string text = "one,two,three,four";
		//string[] parts = text.Split(',', 2); // Splits into a maximum of 2 parts

		//foreach (string part in parts)
		//{
		//	Console.WriteLine(part);
		//}

		//// Example 4: Joining an array of strings with spaces
		//string[] wordsToJoin = { "Hello", "world!" };
		//string joinedString = string.Join(" ", wordsToJoin);

		//Console.WriteLine(joinedString);

		//// Example 5: Joining a list of strings with commas
		//List<string> fruitsToJoin = new List<string>() { "apple", "banana", "cherry" };
		//string joinedFruits = string.Join(",", fruitsToJoin);

		//Console.WriteLine(joinedFruits);
		#endregion

		#region 35- StringBuilder
		////string str = "Hello";
		////str = "Hello World";
		////str += ", I Love Passionate Coders";

		//StringBuilder sb = new StringBuilder(4096);
		//sb.Append("Hello ");
		//sb.Append("World");
		//sb.AppendLine(", I Love Passionate Coders");
		//sb.Append(", Thank you.");

		//Console.WriteLine(sb.ToString());
		//Console.WriteLine($"Length = {sb.Length}");
		//Console.WriteLine($"Capacity = {sb.Capacity}");
		//Console.WriteLine($"MaxCapacity = {sb.MaxCapacity}");
		#endregion

		#region 37- Classes & Objects
		//Console.Write("Enter Student Name: ");
		//string name = Console.ReadLine();

		//Console.Write("Enter Phone Number: ");
		//string phoneNumber = Console.ReadLine(); // Corrected variable name

		//Console.Write("Enter Address: ");
		//string address = Console.ReadLine();

		//Student[] students = new Student[10];
		//Student ahmed = new Student();

		//Console.Write("Enter Student Name: ");
		//ahmed.Name = Console.ReadLine();

		//Console.Write("Enter Phone Number: ");
		//ahmed.PhoneNumber = Console.ReadLine(); // Corrected property name

		//Console.Write("Enter Address: ");
		//ahmed.Address = Console.ReadLine();

		//students[0] = ahmed;

		#endregion

		#region 38- Constructor
		//Student[] students = new Student[10];
		//Student ahmed = new Student("Labib");
		//Student mohammed = new Student("Issa");
		#endregion

		#region 39- Properties
		//Student2 student = new Student2("Mostafa");
		//student.Name = "test";
		//Console.WriteLine(student.Name);
		////student.SetName("Mostafa");
		////Console.WriteLine(student.GetName());
		#endregion

		#region 41- Access Modifiers
		//Access Modifier	Accessibility
		//public			Anywhere
		//internal			Within the same assembly(project)
		//private			Within the same class or struct
		#endregion

		#region 45- ref & out Keywords

		//// ref
		//bool isSuccessful = true;
		//var result = Divide(10, 0, ref isSuccessful);
		//Console.WriteLine($"isSuccessful = {isSuccessful}");
		//Console.WriteLine($"result = {result}");

		////out
		//Console.Write("Please enter a number: ");
		//var isSuccessful = int.TryParse(Console.ReadLine(), out int num);

		//Console.WriteLine($"isSuccessful = {isSuccessful}");
		//Console.WriteLine($"num = {num}");

		#endregion

		#region 46- Exceptions
		//try
		//{
		//	Console.Write("Enter a number: ");
		//	int number = int.Parse(Console.ReadLine()); // Might throw FormatException

		//	int result = 10 / number; // Might throw DivideByZeroException

		//	Console.WriteLine($"Result: {result}");
		//}
		//catch (FormatException ex)
		//{
		//	Console.WriteLine($"Invalid input: {ex.Message}");
		//}
		//catch (DivideByZeroException ex)
		//{
		//	Console.WriteLine($"Cannot divide by zero: {ex.Message}");
		//}
		//catch (Exception ex) // Catch any other exception
		//{
		//	Console.WriteLine($"An error occurred: {ex.Message}");
		//}
		//finally
		//{
		//	Console.WriteLine("Cleanup: This always executes.");
		//}

		#endregion

		#region 47- Enums
		//Console.WriteLine("Available colors:");
		//foreach (ConsoleColorOption color in Enum.GetValues(typeof(ConsoleColorOption)))
		//{
		//	Console.WriteLine(color);
		//}

		//Console.Write("Enter background color: ");
		//string bgColorString = Console.ReadLine();

		//Console.Write("Enter foreground color: ");
		//string fgColorString = Console.ReadLine();

		//ConsoleColorOption bgColor, fgColor;

		//if (Enum.TryParse(bgColorString, out bgColor) && Enum.TryParse(fgColorString, out fgColor))
		//{
		//	Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), bgColor.ToString());
		//	Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), fgColor.ToString());
		//	Console.WriteLine("Colors changed!");
		//}
		//else
		//{
		//	Console.WriteLine("Invalid color entered.");
		//}

		//Console.ReadKey(); // Pause to see the changes
		#endregion

		#region  48- Flags Enums
		//FileAccess access = FileAccess.Read | FileAccess.Write; // Combining flags

		//if ((access & FileAccess.Read) == FileAccess.Read) // Checking if Read flag is set
		//{
		//	Console.WriteLine("Read access granted.");
		//}

		//if ((access & FileAccess.Execute) == FileAccess.Execute) // Checking if Execute flag is set
		//{
		//	Console.WriteLine("Execute access granted.");
		//}
		//else
		//{
		//	Console.WriteLine("Execute access denied.");
		//}

		//FileAccess noRead = access & ~FileAccess.Read; // Removing Read flag

		//Console.WriteLine($"Access: {access}, No Read: {noRead}");
		#endregion

		#region 49- Training App: Random Values Generator

		//while (true)
		//{
		//	Console.WriteLine("[ Random Values Generator ]");
		//	Console.WriteLine("Ask the user to select an option:");
		//	Console.WriteLine("[1] Generate random number [2] Generate random string");

		//	string choice = Console.ReadLine();

		//	if (choice == "1")
		//	{
		//		GenerateRandomNumber();
		//	}
		//	else if (choice == "2")
		//	{
		//		GenerateRandomString();
		//	}
		//	else
		//	{
		//		Console.WriteLine("Invalid choice.");
		//	}

		//	Console.WriteLine("-----------------------------------");
		//}

		#endregion

		#region 50- Training App - File System Command Line
		//while (true)
		//{
		//	Console.Write(">> ");
		//	var input = Console.ReadLine().Trim();

		//	var whiteSpaceIndex = input.IndexOf(' ');
		//	var command = input.Substring(0, whiteSpaceIndex).ToLower();

		//	var path = input.Substring(whiteSpaceIndex + 1).Trim();

		//	if (command == "list")
		//	{
		//		foreach (var entry in Directory.GetDirectories(path, "*C#*"))
		//		{
		//			Console.WriteLine($"\t[Dir] {entry}");
		//		}

		//		foreach (var entry in Directory.GetFiles(path, "*.csproj"))
		//		{
		//			Console.WriteLine($"\t[File] {entry}");
		//		}
		//	}
		//	else if (command == "info")
		//	{
		//		if (Directory.Exists(path))
		//		{
		//			var dirInfo = new DirectoryInfo(path);
		//			Console.WriteLine("Type: Directory");
		//			Console.WriteLine($"Created At: {dirInfo.CreationTime}");
		//			Console.WriteLine($"Last Modified At: {dirInfo.LastWriteTime}");
		//		}
		//		else if (File.Exists(path))
		//		{
		//			var fileInfo = new FileInfo(path);
		//			Console.WriteLine("Type: File");
		//			Console.WriteLine($"Created At: {fileInfo.CreationTime}");
		//			Console.WriteLine($"Last Modified At: {fileInfo.LastWriteTime}");
		//			Console.WriteLine($"Size in Bytes: {fileInfo.Length}");
		//		}
		//	}
		//	else if (command == "mkdir")
		//	{
		//		Directory.CreateDirectory(path);
		//	}
		//	else if (command == "remove")
		//	{
		//		if (Directory.Exists(path))
		//		{
		//			Directory.Delete(path);
		//		}
		//		else if (File.Exists(path))
		//		{
		//			File.Delete(path);
		//		}
		//	}
		//	else if (command == "print")
		//	{
		//		if (File.Exists(path))
		//		{
		//			var content = File.ReadAllText(path);
		//			Console.WriteLine(content);
		//		}
		//	}
		//	else if (command == "exit")
		//	{
		//		break;
		//	}
		//}
		#endregion

		#region  52- Abstract Classes
		//// Cannot create an instance of an abstract class
		//// Shape shape = new Shape(); // This would cause a compilation error

		//Circle circle = new Circle(5);
		//Rectangle rectangle = new Rectangle(4, 6);

		//circle.DisplayInfo();
		//rectangle.DisplayInfo();
		#endregion

		#region 53- Virtual & Protected Members
		//Animal animal1 = new Dog();
		//Animal animal2 = new Cat();

		//animal1.MakeSound(); // Output: Woof!
		//animal2.MakeSound(); // Output: Meow!


		//Car myCar = new Car("Gasoline");
		//myCar.DisplayEngineType(); // Output: Car engine type: Gasoline

		//// This would cause a compilation error:
		//// Console.WriteLine(myCar.engineType); // engineType is protected
		#endregion

		#region 54- Member Hiding/Shadowing
		//DerivedClass derived = new DerivedClass();

		//Console.WriteLine(derived.MyVariable); // Output: 20 (DerivedClass's MyVariable)
		//derived.MyMethod(); // Output: DerivedClass.MyMethod

		//// Accessing the base class member (using casting)
		//Console.WriteLine(((BaseClass)derived).MyVariable); // Output: 10 (BaseClass's MyVariable)
		//((BaseClass)derived).MyMethod(); // Output: BaseClass.MyMethod
		#endregion

		#region 55- Interfaces
		//MyClass obj = new MyClass();
		//obj.DoSomething(); // OK

		//// obj.Log("Test"); // Error! Log is not directly accessible

		//ILogger logger = obj;
		//logger.Log("Test"); // OK (accessing through interface reference)

		#endregion

		#region 56- ArrayList
		ArrayList myList = new ArrayList();

		// Boxing: Adding value types to ArrayList (implicit boxing)
		myList.Add(10); // int is boxed to object
		myList.Add("Hello"); // string is already a reference type
		myList.Add(true); // bool is boxed to object

		// Unboxing: Retrieving and unboxing value types (explicit unboxing)
		int number = (int)myList[0]; // Object is unboxed to int
		string text = (string)myList[1]; // No unboxing (string is reference type)
		bool flag = (bool)myList[2]; // Object is unboxed to bool

		Console.WriteLine($"Number: {number}, Text: {text}, Flag: {flag}");
		#endregion

		#region 57- Generic List & Dictionary
		//List<int> numbers = new List<int>(); // List of integers

		//numbers.Add(10);
		//numbers.Add(20);
		//numbers.Add(30);

		//Console.WriteLine($"Numbers: {string.Join(", ", numbers)}"); // Output: Numbers: 10, 20, 30

		//numbers.Remove(20);

		//Console.WriteLine($"Numbers after removal: {string.Join(", ", numbers)}"); // Output: Numbers: 10, 30

		//Dictionary<string, int> studentScores = new Dictionary<string, int>(); // Dictionary of student names and scores

		//studentScores.Add("Ali", 90);
		//studentScores.Add("Labib", 85);
		//studentScores.Add("Mustafa", 95);

		//Console.WriteLine($"Ali's score: {studentScores["Ali"]}"); // Output: Ali's score: 90

		//if (studentScores.ContainsKey("Labib"))
		//{
		//	studentScores["Labib"] = 88; // Update Labib's score
		//}

		//Console.WriteLine($"Labib's updated score: {studentScores["Labib"]}"); // Output: Labib's updated score: 88
		#endregion

		#region  58- Stack & Queue
		//Stack<int> stack = new Stack<int>();

		//stack.Push(10);
		//stack.Push(20);
		//stack.Push(30);

		//Console.WriteLine($"Top element: {stack.Peek()}"); // Output: 30

		//Console.WriteLine($"Popped element: {stack.Pop()}"); // Output: 30
		//Console.WriteLine($"Popped element: {stack.Pop()}"); // Output: 20

		//Console.WriteLine($"Is stack empty? {stack.Count == 0}"); // Output: False

		//Queue<string> queue = new Queue<string>();

		//queue.Enqueue("Alice");
		//queue.Enqueue("Bob");
		//queue.Enqueue("Charlie");

		//Console.WriteLine($"Front element: {queue.Peek()}"); // Output: Alice

		//Console.WriteLine($"Dequeued element: {queue.Dequeue()}"); // Output: Alice
		//Console.WriteLine($"Dequeued element: {queue.Dequeue()}"); // Output: Bob

		//Console.WriteLine($"Is queue empty? {queue.Count == 0}"); // Output: False

		#endregion

		#region 59- Training: Password Manager

		ReadPasswords();
		while (true)
		{
			Console.WriteLine("Please select an option:");
			Console.WriteLine("1. List all passwords");
			Console.WriteLine("2. Add/Change password");
			Console.WriteLine("3. Get password");
			Console.WriteLine("4. Delete password");

			var selectedOption = Console.ReadLine();

			if (selectedOption == "1")
			{
				ListAllPasswords();
			}
			else if (selectedOption == "2")
			{
				AddOrChangePassword();
			}
			else if (selectedOption == "3")
			{
				GetPassword();
			}
			else if (selectedOption == "4")
			{
				DeletePassword(); // Corrected typo: DeletePasword to DeletePassword
			}
			else
			{
				Console.WriteLine("Invalid option");
			}
			Console.WriteLine("-----------------------------------");

			SavePasswords();
		}

		#endregion
	}



	#region 59- Training: Password Manager
	private static void ListAllPasswords()
	{
		foreach (var entry in _passwordEntries)
		{
			Console.WriteLine($"{entry.Key} is : {entry.Value}");
		}
	}

	private static void AddOrChangePassword()
	{
		Console.Write("Please enter website/app name: ");
		var appName = Console.ReadLine();

		Console.Write("Please enter your password: ");
		var password = Console.ReadLine();

			_passwordEntries[appName] = password;
	}

	private static void GetPassword()
	{
		Console.Write("Please enter website/app name: ");
		var appName = Console.ReadLine();

		if (_passwordEntries.ContainsKey(appName))
		{
			Console.WriteLine($"Your password is: {_passwordEntries[appName]}");
		}
		else
		{
			Console.WriteLine("Password not found");
		}
	}

	private static void DeletePassword()
	{
		Console.Write("Please enter website/app name: ");
		var appName = Console.ReadLine();

		if (_passwordEntries.ContainsKey(appName))
		{
			_passwordEntries.Remove(appName);
		}
		else
		{
			Console.WriteLine("Password not found");
		}
	}
	private static void ReadPasswords()
	{
		if (File.Exists("passwords.txt"))
		{
			var passwordLines = File.ReadAllText("passwords.txt");
			foreach (var line in passwordLines.Split(Environment.NewLine))
			{
				if (!string.IsNullOrEmpty(line))
				{
					//var equalIndex = line.IndexOf('=');
					//var appName = line.Substring(0, equalIndex);
					//var password = line.Substring(equalIndex + 1);
					//_passwordEntries.Add(appName, password);
					var Words = line.Split('=',2);
					var appName = Words[0];
					var password = Words[1];
					_passwordEntries.Add(appName, password);

				}
			}
		}
	}

	private static void SavePasswords()
	{
		var sb = new StringBuilder();
		foreach(var item in  _passwordEntries)
		{
			sb.AppendLine($"{item.Key}={item.Value}");
		}
		File.WriteAllText("passwords.txt",sb.ToString());
	}
	#endregion

	#region 45- ref & out Keywords
	static double Divide(double number, double divisor, ref bool isSuccessful)
	{
		if (divisor == 0)
		{
			Console.WriteLine("Can't divide on Zero !");
			isSuccessful = false;
			return 0;
		}
		isSuccessful = true;
		return number / divisor;
	}
	static double DivideOut(double number, double divisor, out bool isSuccessful)
	{
		if (divisor == 0)
		{
			Console.WriteLine("Can't divide on Zero!");
			isSuccessful = false;
			return 0;
		}
		isSuccessful = true;
		return number / divisor;
	}

	#endregion

	#region 49- Training App: Random Values Generator
	public static void GenerateRandomNumber()
	{
		Console.Write("Enter minimum value: ");
		if (!int.TryParse(Console.ReadLine(), out int min))
		{
			Console.WriteLine("Invalid minimum value.");
			return;
		}

		Console.Write("Enter maximum value: ");
		if (!int.TryParse(Console.ReadLine(), out int max))
		{
			Console.WriteLine("Invalid maximum value.");
			return;
		}

		if (min > max)
		{
			Console.WriteLine("Minimum value cannot be greater than maximum value.");
			return;
		}

		Random random = new Random();
		int randomNumber = random.Next(min, max + 1);
		Console.WriteLine($"Random number: {randomNumber}");
	}

	public static void GenerateRandomString()
	{
		Console.Write("Enter string length: ");
		if (!int.TryParse(Console.ReadLine(), out int length) || length <= 0)
		{
			Console.WriteLine("Invalid string length.");
			return;
		}

		Console.Write("[1] Include capital letters? (yes/no): ");
		bool includeCapitals = Console.ReadLine().ToLower() == "yes";

		Console.Write("[2] Include small letters? (yes/no): ");
		bool includeLowercase = Console.ReadLine().ToLower() == "yes";

		Console.Write("[3] Include numbers? (yes/no): ");
		bool includeNumbers = Console.ReadLine().ToLower() == "yes";

		Console.Write("[4] Include symbols? (yes/no): ");
		bool includeSymbols = Console.ReadLine().ToLower() == "yes";

		if (!includeCapitals && !includeLowercase && !includeNumbers && !includeSymbols)
		{
			Console.WriteLine("At least one character type must be selected.");
			return;
		}

		string capitals = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		string lowercase = "abcdefghijklmnopqrstuvwxyz";
		string numbers = "0123456789";
		string symbols = "!@#$%^&*()-_+=~`[]{}|\\:;\"'<>,.?/";

		StringBuilder allowedChars = new StringBuilder();
		if (includeCapitals) allowedChars.Append(capitals);
		if (includeLowercase) allowedChars.Append(lowercase);
		if (includeNumbers) allowedChars.Append(numbers);
		if (includeSymbols) allowedChars.Append(symbols);

		Random random = new Random();
		StringBuilder result = new StringBuilder();
		for (int i = 0; i < length; i++)
		{
			int randomIndex = random.Next(allowedChars.Length);
			result.Append(allowedChars[randomIndex]);
		}

		Console.WriteLine($"Random string: {result}");
	}
	#endregion


}
#region 37- Classes & Objects
public class Student
{
	#region 38- Constructor
	public Student(string name)
	{
		Console.WriteLine("A new student has been initialized");
		Name = name;
	}

	#endregion
	public string? Name { get; set; }
	public string ?PhoneNumber { get; set; }
	public string ?Address { get; set; }
}
#endregion

#region 39- Properties
public class Student2
{
	public Student2(string name)
	{
		Name = name;
	}
	public string? Name { get; set; }

	//private string _name;
	
	//public string Name
	//{
	//	set
	//	{
	//		_name = value;
	//	}
	//}

	// private string _name;
	// public string GetName()
	// {
	//     return _name;
	// }

	// public void SetName(string name)
	// {
	//     _name = name;
	// }

	// private string _name;
	// public string Name
	// {
	//     get
	//     {
	//         return _name;
	//     }
	// }
}
#endregion

#region 42- Constants & Read-Only Variables
//public class MyClass
//{
//	const int MaxStudents = 30;
//	const string CompanyName = "ABC Corp";

//	public readonly int InstanceNumber;
//	public static readonly DateTime CreationTime;

//	public MyClass(int number)
//	{
//		InstanceNumber = number; // Initialized in constructor
//	}

//	static MyClass()
//	{
//		CreationTime = DateTime.Now; // Initialized in static constructor
//	}
//	/*
//	Feature				Constant (const)				Read-Only (readonly)
//	Initialization	    At declaration					At declaration or in constructor
//	Evaluation		    Compile time					Run time
//	Allowed			    Types	Built-in				types, enums	Any type
//	Static/Instance	    Implicitly static				Can be instance or static
//	Usage			    Values known at compile time	Values determined at run time
//	Performance  	    Slightly faster (compile-time)	Slightly slower (run-time) 
//	 */
//}
#endregion

#region  44- Variable Scopes
public class MyClass3
{
	// Class-Level Scope (also known as Field or Member Scope)
	private int classLevelVariable = 10; // Accessible throughout the class

	public void MyMethod()
	{
		// Method-Level Scope
		int methodLevelVariable = 20; // Accessible only within MyMethod()

		if (true)
		{
			// Block-Level Scope
			int blockLevelVariable = 30; // Accessible only within this if block

			// Accessing variables from outer scopes
			Console.WriteLine(classLevelVariable); // OK
			Console.WriteLine(methodLevelVariable); // OK
			Console.WriteLine(blockLevelVariable); // OK
		}

		// Accessing variables from outer scopes
		Console.WriteLine(classLevelVariable); // OK
		Console.WriteLine(methodLevelVariable); // OK
												// Console.WriteLine(blockLevelVariable); // Error! blockLevelVariable is out of scope here

		// Modifying class-level variable
		classLevelVariable = 40;
	}

	public void AnotherMethod()
	{
		// Accessing class-level variable
		Console.WriteLine(classLevelVariable); // OK

		// Console.WriteLine(methodLevelVariable); // Error! methodLevelVariable is out of scope here
		// Console.WriteLine(blockLevelVariable); // Error! blockLevelVariable is out of scope here
	}
}
#endregion

#region 51- Simple Math Expression Evaluator
public enum MathOperation
{
	None,
	Addition,
	Subtraction,
	Multiplication,
	Division,
	Modulus,
	Power,
	Sin,
	Cos,
	Tan,
}

public class MathExpression
{
	public double LeftSideOperand { get; set; }
	public double RightSideOperand { get; set; }
	public MathOperation Operation { get; set; }

	public double Evaluate()
	{
		switch (Operation)
		{
			case MathOperation.Addition:
				return LeftSideOperand + RightSideOperand;
			case MathOperation.Subtraction:
				return LeftSideOperand - RightSideOperand;
			case MathOperation.Multiplication:
				return LeftSideOperand * RightSideOperand;
			case MathOperation.Division:
				if (RightSideOperand == 0)
				{
					throw new DivideByZeroException("Cannot divide by zero.");
				}
				return LeftSideOperand / RightSideOperand;
			case MathOperation.Modulus:
				if (RightSideOperand == 0)
				{
					throw new DivideByZeroException("Cannot perform modulus by zero.");
				}
				return LeftSideOperand % RightSideOperand;
			case MathOperation.Power:
				return Math.Pow(LeftSideOperand, RightSideOperand);
			case MathOperation.Sin:
				return Math.Sin(RightSideOperand); //Assuming LeftSideOperand is not used for sin,cos,tan.
			case MathOperation.Cos:
				return Math.Cos(RightSideOperand);
			case MathOperation.Tan:
				return Math.Tan(RightSideOperand);
			case MathOperation.None:
			default:
				return 0; // Or throw an exception for invalid operation
		}
	}

	public override string ToString()
	{
		return $"{LeftSideOperand} {Operation} {RightSideOperand}";
	}

}

public static class ExpressionParser
{
	public static MathExpression Parse(string expressionString)
	{
		// Simple parsing logic (can be improved)
		string[] parts = expressionString.Split(' ');
		if (parts.Length != 3)
		{
			throw new ArgumentException("Invalid expression format.");
		}

		double leftOperand;
		if (!double.TryParse(parts[0], out leftOperand))
		{
			throw new ArgumentException("Invalid left operand.");
		}

		MathOperation operation;
		if (!Enum.TryParse(parts[1], true, out operation))
		{
			throw new ArgumentException("Invalid operation.");
		}

		double rightOperand;
		if (!double.TryParse(parts[2], out rightOperand))
		{
			throw new ArgumentException("Invalid right operand.");
		}

		return new MathExpression
		{
			LeftSideOperand = leftOperand,
			Operation = operation,
			RightSideOperand = rightOperand
		};
	}

}
#endregion


#region  52- Abstract Classes
// Abstract class representing a general shape
//public abstract class Shape
//{
//	// Abstract property to get the area of the shape
//	public abstract double Area { get; }

//	// Abstract method to draw the shape
//	public abstract void Draw();

//	// Concrete method that can be used by all derived classes
//	public void DisplayInfo()
//	{
//		Console.WriteLine($"Area: {Area}");
//		Console.WriteLine("Drawing the shape...");
//		Draw();
//	}
//}

//// Concrete class representing a circle, derived from Shape
//public class Circle : Shape
//{
//	public double Radius { get; set; }

//	public Circle(double radius)
//	{
//		Radius = radius;
//	}

//	public override double Area => Math.PI * Radius * Radius;

//	public override void Draw()
//	{
//		Console.WriteLine("Drawing a circle.");
//	}
//}

//// Concrete class representing a rectangle, derived from Shape
//public class Rectangle : Shape
//{
//	public double Width { get; set; }
//	public double Height { get; set; }

//	public Rectangle(double width, double height)
//	{
//		Width = width;
//		Height = height;
//	}

//	public override double Area => Width * Height;

//	public override void Draw()
//	{
//		Console.WriteLine("Drawing a rectangle.");
//	}
//}

#endregion

#region 53- Virtual & Protected Members
public class Animal
{
	public virtual void MakeSound()
	{
		Console.WriteLine("Generic animal sound.");
	}
}

public class Dog : Animal
{
	public override void MakeSound()
	{
		Console.WriteLine("Woof!");
	}
}

public class Cat : Animal
{
	public override void MakeSound()
	{
		Console.WriteLine("Meow!");
	}
}

public class Vehicle
{
	protected string engineType;

	public Vehicle(string engineType)
	{
		this.engineType = engineType;
	}

	public virtual void DisplayEngineType()
	{
		Console.WriteLine($"Engine type: {engineType}");
	}
}

public class Car : Vehicle
{
	public Car(string engineType) : base(engineType) { }

	public override void DisplayEngineType()
	{
		Console.WriteLine($"Car engine type: {engineType}");
	}
}

#endregion

#region 54- Member Hiding/Shadowing
public class BaseClass
{
	public int MyVariable = 10;

	public void MyMethod()
	{
		Console.WriteLine("BaseClass.MyMethod");
	}
}

public class DerivedClass : BaseClass
{
	// Hiding the base class's MyVariable
	public new int MyVariable = 20;

	// Hiding the base class's MyMethod
	public new void MyMethod()
	{
		Console.WriteLine("DerivedClass.MyMethod");
	}
}

#endregion

#region 55- Interfaces

//implicit 
public interface IDrawable
{
	void Draw(); // Method declaration (no implementation)
	int PositionX { get; set; } // Property declaration
}

public class Circle : IDrawable
{
	public int PositionX { get; set; }

	public void Draw()
	{
		Console.WriteLine($"Drawing circle at X: {PositionX}");
	}
}

public class Square : IDrawable
{
	public int PositionX { get; set; }

	public void Draw()
	{
		Console.WriteLine($"Drawing square at X: {PositionX}");
	}
}
//explicit 
public interface ILogger
{
	void Log(string message);
}

public class MyClass : ILogger
{
	void ILogger.Log(string message) // Explicit implementation
	{
		Console.WriteLine($"[Logger] {message}");
	}

	public void DoSomething()
	{
		Console.WriteLine("Doing something...");
	}
}
/*         
Feature			 Interface												Abstract Class
Members			 Only method, property, event, indexer declarations		Can have method, property, event, indexer declarations and implementations; fields
Inheritance		 A class can implement multiple interfaces				A class can inherit from only one abstract class
Implementation	 No implementation details								Can have partial implementation
Purpose			 Define a contract or behavior							Provide a base class with common functionality
Keywords		 interface, implements									abstract, extends
 */

#endregion

