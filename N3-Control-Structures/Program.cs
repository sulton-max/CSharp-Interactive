// Flow Control Intro

// Linear execution

Console.WriteLine("Linear execution");
var greeting = "Hello {0}";
Console.WriteLine(greeting, "User");
Console.WriteLine();

// Branching 
Console.WriteLine("Branching \n");

// Branching with If, If-Else, Switch
Console.WriteLine("if - else \n");

// IsNullOrWhiteSpace
// null - true
// "" - true
// " " - true
// "text" - false

// If - Else
Console.Write("Enter you username : ");
var firstnameInput = Console.ReadLine();
if (string.IsNullOrWhiteSpace(firstnameInput))    // Validation
{
    Console.WriteLine(greeting, "User");
}
else
{
    Console.WriteLine(greeting, firstnameInput);
}

// false, true 
// !false = true
// !true = false

// If
if (!string.IsNullOrWhiteSpace(firstnameInput))
{
    Console.WriteLine("Welcome");
}

var nationality = "You're {0}";

// Else - If
if (firstnameInput == "Akbar")
    Console.WriteLine(nationality, "Uzbek");
else if (firstnameInput == "Misha")
    Console.WriteLine(nationality, "Russian");
else if (firstnameInput == "John")
    Console.WriteLine(nationality, "American");
else
    Console.WriteLine("Wow! You're Alien");

// Nested If
Console.Write("Enter you email : ");
var emailInput = Console.ReadLine();

// t@gmail.com
// t@yahoo.com

if (!string.IsNullOrWhiteSpace(emailInput))
{
    if (emailInput.Length > 5)
    {
        if (emailInput != "test@gmail.com")
        {
            Console.WriteLine("Verification email send to your address");
        }
        else
        {
            Console.WriteLine("Are you tester ?");
        }
    }
    else
    {
        Console.WriteLine("Email is too short");
    }
}
else
{
    Console.WriteLine("Email is empty");
}
Console.WriteLine();


// Switch 
Console.Write("Are you hiring or applying ? (h/a) : ");
var option = Console.ReadLine();

switch(option)
{
    case "h": // hiring
        {
            Console.WriteLine("Creating account for company");
            Console.WriteLine("Sending verification email");
            Console.WriteLine("Creating dashboard");
            break;
        } 
    case "a": // applying
        {
            Console.WriteLine("Creating account for talant");
            Console.WriteLine("Sending verification email");
            Console.WriteLine("Searching jobs for talent");
            break;
        }
    default:
        Console.WriteLine("I don't know what to do");       
        break;
}
Console.WriteLine();


// Switch expression
Console.Write("Enter your age : ");
var ageInput = int.Parse(Console.ReadLine());
var ageValidationMessage = ageInput switch
{
    < 0 => "Vapshe invalid",
    < 18 => "You're not eligible",
    > 18 and < 70 => "Valid",
    > 150 => "But this is impossible",
    > 100 => "Congrats, but enjoy your life",
    > 70 => "Sorry, you're too old",
    _ => "Invalid"
};

Console.WriteLine(ageValidationMessage);

// continue, break

// Looping

// Loops with For, ForEach, While, Do-While