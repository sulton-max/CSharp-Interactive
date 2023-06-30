// Concatenation
Console.WriteLine("Concatenation : ");
var firstName = "Zafar";
var lastName = "Urakov";
var fullName = firstName + " " + lastName;

Console.WriteLine($"Fullname : {fullName}");
Console.WriteLine();

// Escape Characters
Console.WriteLine("Escape Characters : ");
var complexString = "\"Asp.NET Core in Action\" by Andrew Troelson";

Console.WriteLine(complexString);
Console.WriteLine();

// Interpolation and Formatting
Console.WriteLine("Interpolation : ");

var age = 10;
Console.WriteLine($"Age: {age}");

var greetingText = "Hello, {0} {1}, {0} how are you doing ?";
var greeting = string.Format(greetingText, "Zafar", "Welcome");

Console.WriteLine("Formatting : ");
Console.WriteLine(greeting);
Console.WriteLine("Formatted greeting text : {0}", greeting);
Console.WriteLine();

// Verbatim String
Console.WriteLine("Verbatim string : ");
var longText = @$"
       This is an example
       of a long text
       age : {age}
";
Console.WriteLine(longText);

var filePathA = @"D:\Temp\Card\Card\bin\Debug\net7.0\Card.exe";
var filePathB = @"D:\nattery-report.html";
Console.WriteLine(filePathA);
Console.WriteLine();

// Length, Indexing, Substring
Console.WriteLine("Length : ");
var simpleText = "Console";
Console.WriteLine($"Lenth of word \"{simpleText}\" - {simpleText.Length}");

var symbol = simpleText[0];
Console.WriteLine($"Symbol at index 0 : {symbol}");

var substring = simpleText.Substring(0, 3);
Console.WriteLine($"Substring of word \"{simpleText}\" from index 0 with length 3 : {substring}");

Console.WriteLine();
// Splitting and Joining

// Cases, Case operations

// Comparison and Equality

// Searching

// Replacing

// Trimg and Padding
