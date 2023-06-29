// Variable definition - o'zgaruvchi e'lon qilish
string example;

// Variable with emtpy value - qiymatsiz o'zgaruvchi
//Console.WriteLine(example);
//string test = example;

// Variable initialization - o'zgaruvchiga boshlang'ich qiymat
example = "Men C# tilida gapiraman";

// Variable definition and initilization - o'zgaruvchi e'lon qilish va shu joyda boshlang'ich qiymat berish
string exampleB = "Men C# tilida gapiraman";

// Assigning a new value to variable - o'zgaruvchiga yangi qiymat berish
example = "Men Python tilida gapiraman";

// Read operation - o'zgaruvchi qiymatini olish
string value = example;

// Write operation - o'zgaruvchi qiymatiga yozish
example = "Yangi qiymat";

// RAM - ram xotira
// ROM - doimiy xotira

// Output to console - konsolga chiqarish
Console.WriteLine("qiymat");
Console.WriteLine(example);

// Input from console - konsoldan kiritish
var input = Console.ReadLine();
Console.WriteLine(input);

// Can't only define consts - konstantalarni faqat e'lon qilishni iloji yo'q
//const double pi;
//pi = 3.14;

// Const values - konstantalar
const string constValue = "C# bu OOP til";
const int examTime = 120;

// No write to const - konstantalarga yozish mumkinmas
//constValue = "C# bu functional language";
//examTime = 60;

// Explicit type - tipni ochiq e'lon qilish
string laptopA = "Asus Laptop";

// Implicit type - tipni bilvosita e'lon qilish
var laptopB = "Asus Laptop";

// Implicity typed variables must be initilialized
// - bilvosite tipdagi o'zgaruvchilar e'lon qilinganda boshlang'ich qiymat berilishi shart
//var userAge;
//userAge = 32;

// Boolean - bool
var isDayTime = true;

// Char - simvol
var emailAddressSymbol = '@';

// Sbyte - signed byte - ishorali byte
sbyte roomTemperature = 22;

// Byte - byte 
byte userAge = 100;

// Ushort - unsigned short - ishorasiz qisqa butun son 
ushort districtPopulation = 55_000;

// Short - short - qisqa butun son
short shortValue = -30_000;

// Uint and digit separator - unsigned integer - ishorasiz butun son va raqamlarni ajratuvchi
uint uintValue = 4_000_000_000;

// Int - integer - butun son
int intValue = -2_000_000_000;

// ULong
ulong ulongValue = 18_446_744_073_709_551_615;

// Long
long longValue = -9_223_372_036_854_775_808;

// Float - floating point value - kasr son 0.5
float normalHumanTemparature = 36.6F;

// Double - double precision floating value - 2 marta aniq kasr son 
double pi = Math.PI;

// Decimal
decimal decimalValue = 1.000_000_000_000_000_000_000_000_000_000_000_001m;

// String
string stringValue = "This is first C# class";

// DateTime
DateTime date = DateTime.Now;

// Guid - global unique id - global yagona id
Guid guid = Guid.NewGuid();

// Why we nee Guid - Guid bizga nimaga kerak
var studentANumber = 1;
var studentBNumber = 2;
var studentCNumber = 3;
var studentDNumber = 4;
var studentENumber = 4;
var studentFNumber = studentENumber + 1;

// Arrays - massiv

// Array initialization 

// Initialization with element numbers - elementlarni sonini e'lon qilganda belgilash
string[] friends;
friends = new string[3]
{
    "John",
    "Tom",
    "Tim"
};

// Initialization without element numbers - elementlarni sonini belgilamasdan e'lon qilish
var peopleOnQueue = new string[]
{
    "John",
    "Tom",
    "Tim"
};

// One directional - bir o'lchamli massiv
var smallHotelRooms = new int[]
{
    3,
    4,
    5,
    6,
    7
};

// Multi directional - ko'p o'lchamli massiv
var bigHotelRooms = new int[,]
{
    { 1,2,3 },
    { 4,5,6 },
    { 7,8,9 }
};

// Jagged - 
var realHotelRooms = new int[][]
{
    new int[] { 1,2,3 },
    new int[0],
    new int[] { 7,8,9,10,11}
};

// Accessing array elements - massiv elementlariga murojaat qilish - massiv elementlari 0 dan boshalanadi

// 6 * 1
// 6 * 2
// 6 * 3

var table = new int[3, 2];
table[0, 0] = 6;
table[0, 1] = 1;
table[1, 0] = 6;
table[1, 1] = 2;
table[2, 0] = 6;
table[2, 1] = 3;

Console.WriteLine($"{table[0, 0]} * {table[0,1]} = {table[0,0] * table[0,1]}");

// Const value or Literal
var boolLiteral = true;
var charLiteral = '&';
var sbyteLiteral = (sbyte)-124;
var byteLiteral = (byte)255;
var ushortLiteral = (ushort)10;
var shortLiteral = (short)10;
var uintLiteral = 10U;
var intLiteral = 10;
var ulongLiteral = 10UL;
var longLiteral = 10L;
var floatLiteral = 10F;
var doubleLiteral = 10D;
var decimalLiteral = 10M;
var stringLiteral = "10";

// Primitive and Complex Types - primitiv va murakkab tiplar

// Primitive - bool, char, sbyte, byte, ushort, short, uint, int, ulong, long, float, double, decimal, string
// Complex - any other

// Built-In and Custom Types - bor bo'lgan tiplar va maxsus tip

// Built-In - all primitive and Guid, Date and other
// Custom - any typed defined by us - bizlar e'lon qilgan tiplar

// Value and Reference Types

// Value - char, bool
// Reference - string

// Static and Dynamic Types

// Static - any other
var number = 10;
//number = "10";

// Dynamic - object, dynamic
object objectValue = DateTime.Now;
objectValue = "45";
//objectValue.Days;

dynamic dynamicValue = 45;
dynamicValue = "45";
var days = dynamicValue.Days; // doesn't work

// Hierarchy 

