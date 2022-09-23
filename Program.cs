// See https://aka.ms/new-console-template for more information


//დაბეჭდავს კლავიატურიდან შემოტანილ ტექსტს.(სახელს და გვარს)
Console.WriteLine("Enter Name :");
string name= Console.ReadLine();
Console.WriteLine($"Hello,My name is {name}");

//კლავიატურიდან შემოიტანს ორ რიცხვს და დაბეჭდავს მათ : ჯამს , სხვაობას, ნამრავლს, პირველი რიცხვის მეორეზე გაყოფის ნაშთს.

int num1, num2, sum, sub, mult, rem;
Console.WriteLine("Calculate the sum,sub,mult,rem of two numbers:");
Console.Write(" Input number 1: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write(" Input number 2: ");
num2 = Convert.ToInt32(Console.ReadLine());
sum = num1 + num2;
sub = num1 - num2;
mult = num1 * num2;
rem = num1 % num2;
Console.WriteLine("{0} + {1} = {2}", num1, num2, sum);
Console.WriteLine("{0} - {1} = {3}", num1, num2, sub);
Console.WriteLine("{0} * {1} = {4}", num1, num2, mult);
Console.WriteLine("{0} % {1} = {5}", num1, num2, rem);



//Console.ReadKey();






//კლავიატურიდან შემოიტანს ორ რიცხვს და გაუცვლის მათ მნიშვნელობას. (მაგ. თუ x-ში შეინახავთ რიცხვს 5-ს y-ში 3-ს უნდა დაწეროთ პროგრამა რომლის შედეგადაც x და y ის მნიშვნელობა გაუცვლის ადგილს ერთმანეთს.(swap)


int number1, number2,test;
Console.WriteLine("Enter number 1 :");
number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number 2 :");
number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Before swapping number1 ={0} and number2={1}",number1,number2);
test = number1;
number1 = number2;
number2 = test;
Console.WriteLine("after swaping number1 ={0} and number2={1}",number1,number2);
Console.ReadKey();



//კონსოლიდან (კლავიატურიდან) შემოიტანს 4 რიცხვს და გამოითვლის ამ რიცხვების საშუალოს.

int integer1, integer2, integer3, integer4;
Console.WriteLine("Enter first number");
integer1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number");
integer2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter third number");
integer3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter fourth number");
integer4 = Convert.ToInt32(Console.ReadLine());

int result = (integer1 + integer2 + integer3 + integer4) / 4;

Console.WriteLine("The average of {0}, {1}, {2}, {3} is: {4} ",
  integer1, integer2, integer3, integer4, result);



//რომელიც კელვინს გადაიყვანს ცელსიუსში

Console.Write("print kelvin: ");
int kelvin = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("celsius is {0}", kelvin - 273);


//კლავიატურიდან შემოიტანს რიცხვს და თუ ეს რიცხვი დადებითია დაბეჭდავს ტექსტ “number is positive”

int random;
string str1 = Console.ReadLine();
bool randomIsPositive = int.TryParse(str1, out random);

if (random >0)
{
    Console.WriteLine("number is positive");
}
else
{
    Console.WriteLine("number is undefined");
}

//კლავიატურიდან შემოიტანს 3 რიცხვს და დაბეჭდავს ამ 3 რიცხვიდან უმცირესს /უდიდესს

int a, b, c;
Console.WriteLine("Enter first number");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter third number");
c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Largest of three: " + Math.Max(a, Math.Max(b, c)));
Console.WriteLine("Lowest of three: " + Math.Min(a, Math.Min(b, c))); //actual code


//i tried it 
if (a > b && a > c)
{
    Console.WriteLine($"{a} is max");
}
if (b > c && b > a)
 {
    Console.WriteLine($"{b} is max");
 }
 else
 {
    Console.WriteLine($"{c} is max");
  };
//  maybe that works as well idk, wont write on min dd 





//კლავიატურიდან შემოიტანს ორ რიცხვს და თუ ეს ორი რიცხვი ტოლია გაზრდის მათ მნიშვნელობებს 3 ჯერ


int x, y;
Console.WriteLine("Enter first number");
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number");
y = Convert.ToInt32(Console.ReadLine());
int resultSecond = 3*y;
int resultFirst = 3*x;

if (x == y)
{
    Console.WriteLine($"Two numbers are equal, {x} becomes {resultFirst}, {y} is {resultSecond}");
}
else
{
    Console.WriteLine("numbers arent equal");
}


//კლავიატურიდან შემოტანილ რიცხვს შეამოწმებს არის თუ არა 7 -ის ჯერადი.


int k;
Console.WriteLine("Enter integer ");
k = Convert.ToInt32(Console.ReadLine());
if (k % 7 == 0)
{
    Console.WriteLine("Number is divisible by 7");
}
else
{
    Console.WriteLine("Number is not divisible by 7");
}


//კლავიატურიდან შემოიტანს რიცხვს და დაბეჭდავს შეიცავს თუ არა ეს რიცხვი ციფრ 5-ს


string l;
l = Console.ReadLine();
string j = "5";
Console.WriteLine(l.Contains(j));

//კლავიატურიდან შემოიტანს ამ რიცხვს და დაბეჭდავს ამ რიცხვის ციფრებს.(მაგ 324 უნდა დაბეჭდოს 3 2 


/*will write  it down for assigned number 324 otherwise cant figure it out. so i try to devide 324
 * and want to get 3 pieces. first of all, i will split 32-4 , means that i will find:324%10=4
 * i have 324-320=4 and 320 itself. 320/2=32 , 32%10= 2 , 30/10=3.  so i got 3 2 4  or */




var myString = Console.ReadLine();
var charArray = myString.ToCharArray();