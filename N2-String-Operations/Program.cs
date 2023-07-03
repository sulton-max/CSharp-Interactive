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
var loremText = "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Saepe rem consequuntur voluptate, " +
    "similique placeat provident incidunt quos fuga, suscipit doloribus voluptatem";

var words = loremText.Split(' ');
var sentences = loremText.Split('.');
var duplicateTextSplit = loremText.Split("voluptatem");

Console.WriteLine("Words : ");
foreach (var word in words)
    Console.WriteLine(word + "\n");
Console.WriteLine();

Console.WriteLine("Sentences : ");
foreach (var word in sentences)
    Console.WriteLine(word + "\n");
Console.WriteLine();

Console.WriteLine("Duplicate word text: ");
foreach (var word in duplicateTextSplit)
    Console.WriteLine(word + "\n");

var input = Console.ReadLine();
var splitInput = input.Split(' ');
var numberA = int.Parse(splitInput[0]);
var numberB = int.Parse(splitInput[1]);

Console.WriteLine($"Number A : {numberA}");
Console.WriteLine($"Number B : {numberB}");

// Cases, Case operations
var john = "John";
var firstNameA = firstName.ToLower();
var firstNameC = firstName.ToLowerInvariant();
var firstNameB = firstName.ToUpper();
var firstNameD = firstName.ToUpperInvariant();

Console.WriteLine($"Firstname in lower case : {firstNameA}");
Console.WriteLine($"Firstname in lower case invariant: {firstNameC}");
Console.WriteLine($"Firstname in upper case : {firstNameB}");
Console.WriteLine($"Firstname in upper case invariant: {firstNameD}");
Console.WriteLine();


//var test = "a".ToLower()[0];

// Comparison and Equality
var textToCompareA = "John";
var textToCompareB = "John";


// Results
// -1 - first string comes first in alphabet
// 0  - strings are equal
// 1  - first string comes second

Console.WriteLine($"Compare result of {textToCompareA} {textToCompareB} : {textToCompareA.CompareTo(textToCompareB)}");
Console.WriteLine($"Equals result of {textToCompareA} {textToCompareB} : {textToCompareA.Equals(textToCompareB)}");
Console.WriteLine($"EqualsSequence result of {textToCompareA} {textToCompareB} : {textToCompareA.SequenceEqual(textToCompareB)}");
Console.WriteLine($"= result of {textToCompareA} {textToCompareB} : {textToCompareA == textToCompareB}");
Console.WriteLine();

var objectA = (object)1;
var objectB = (object)1;

Console.WriteLine($"object A == object B : {objectA == objectB}");
Console.WriteLine($"object A Equals object B : {objectA.Equals(objectB)}");
Console.WriteLine($"object A object.Equals object B : {object.Equals(objectA, objectB)}");
Console.WriteLine($"object A object.ReferenceEquals object B : {object.ReferenceEquals(objectA, objectB)}");
Console.WriteLine();

// Searching

// Start with
Console.WriteLine($"StartsWith char -  {textToCompareA.StartsWith('j')}");
Console.WriteLine($"StartsWith string -  {textToCompareA.StartsWith("jo")}");
Console.WriteLine($"StartsWith string with ignore case - {textToCompareA.StartsWith("jo", StringComparison.OrdinalIgnoreCase)}");

// End with
Console.WriteLine($"End with string with ignore case - {textToCompareA.EndsWith("Hn", StringComparison.OrdinalIgnoreCase)}");

// Contains
Console.WriteLine($"Contains with ignore case - {loremText.Contains("ProVidE", StringComparison.OrdinalIgnoreCase)}");
Console.WriteLine();

// Replacing
var passwordChangeEmail = "Dear {{User}}! Your new password is {{Password}}";
var userToken = "{{User}}"; // token
var passwordToken = "{{Password}}";

var email = passwordChangeEmail.Replace(userToken, "Zafar").Replace(passwordToken, "23456789");
Console.WriteLine($"Sending email : {email}");

// Trim and Padding
var untrimmedText = "                               text value                                 ";
var trimmedText = untrimmedText.Trim();
Console.WriteLine($"Text : {untrimmedText}, after trim : {trimmedText}");

Console.WriteLine("Example with replace, trim");
var securityMessage = "This is credential! {{Password}}";

var messageForUser = securityMessage.Replace(passwordToken, "23456789");
var messageForModerator = securityMessage.Replace(passwordToken, "********");
var messageForAssistant = messageForModerator.Trim('*');

Console.WriteLine();
Console.WriteLine($"Message for user {messageForUser}");
Console.WriteLine($"Message for moderator {messageForModerator}");
Console.WriteLine($"Message for assistant {messageForAssistant}");
Console.WriteLine();


Console.WriteLine($"Text : {untrimmedText}, after trim start : {untrimmedText.TrimStart()}");
Console.WriteLine($"Text : {untrimmedText}, after trim end : {untrimmedText.TrimEnd()}");

untrimmedText.TrimEnd();
untrimmedText.TrimStart();
untrimmedText.Trim();

Console.WriteLine($"Does strim get affected ? - {untrimmedText}");

Console.WriteLine();
var questionSample = "I go to";
var question = questionSample.PadRight(20, '*');
Console.WriteLine($"Question : {question}");
