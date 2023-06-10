//Первое задание
int FirstSide = 3; 
int SecondSide = 5;
int areaRectangle = FirstSide * SecondSide;
Console.WriteLine(areaRectangle);

// Второе задание 
int FirstLeg = 3;
int SecondLeg = 12;
int areaTriangle = FirstLeg * SecondLeg;
Console.WriteLine(areaTriangle);
//Третье задание первый способ 
Console.Write("Write First number: ");
    int FirstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("select the sign of operations'+,-,*,/,%' :");
char operations = Convert.ToChar(Console.ReadLine());
Console.Write("Write Second number:");
int SecondNumber = Convert.ToInt32(Console.ReadLine());
if (operations == '+')
{
    Console.Write($"{FirstNumber}+{SecondNumber}={FirstNumber + SecondNumber}");
}
else if (operations == '-')
{
    Console.Write($"{FirstNumber}-{SecondNumber}={FirstNumber - SecondNumber}");
}
else if (operations == '*')
{
    Console.Write($"{FirstNumber}*{SecondNumber}={FirstNumber * SecondNumber}");
}
else if (operations == '/')
{
    Console.Write($"{FirstNumber}/{SecondNumber}={FirstNumber / SecondNumber}");
}
else if (operations =='%')
{
    Console.Write($"{FirstNumber}%{SecondNumber}={FirstNumber % SecondNumber}");
}
/* через конструкцию switch
switch(operations)
{
    case '+':
        {
            Console.Write($"{FirstNumber}+{SecondNumber}={FirstNumber + SecondNumber}");
        }
        break;
    case '-':
        {
            Console.Write($"{FirstNumber}-{SecondNumber}={FirstNumber - SecondNumber}");
        }
        break;
    case '/':
        {
            Console.Write($"{FirstNumber}/{SecondNumber}={FirstNumber / SecondNumber}");
        }
        break;
    case '*':
        {
            Console.Write($"{FirstNumber}*{SecondNumber}={FirstNumber * SecondNumber}");
        }
        break;
    case '%':
        {
            Console.Write($"{FirstNumber}%{SecondNumber}={FirstNumber % SecondNumber}");
        }

        break;
    
}
*/


//четвертое задание


Console.Write("write you full age:");
int age =Convert.ToInt32(Console.ReadLine());
if(age<18)
{
    Console.Write("result = underage");
}
else
{
    Console.Write( "result = adult");
}
/* второй способ
Console.Write("write you full age:");
int age = Convert.ToInt32(Console.ReadLine());
string underage = "underage";
string adult = "adult";
var ChekAge = age<18 ? underage : adult;
Console.WriteLine(ChekAge); */

// пятое задание

Console.Write("write temperature:");
int Temperature = Convert.ToInt32(Console.ReadLine());

if(Temperature <0)
{
    Console.WriteLine( "very cold");
}
else if (Temperature <=10)
{
    Console.WriteLine("cold");
}
else if (Temperature <= 20)
{
    Console.WriteLine("normal");
}
else if (Temperature <= 30)
{
    Console.WriteLine("warm");

}
else 
{
    Console.WriteLine("hot");
}

//шестое задание 


Console.Write("write month: ");
int month = Convert.ToInt32(Console.ReadLine());
if (month < 3)
    Console.WriteLine("winter");
else if (month < 6)
    Console.WriteLine("spring");
else if (month < 9)
    Console.WriteLine("summer");
else if (month < 12)
    Console.WriteLine("autumn");
else if (month < 13)
    Console.WriteLine("winter");
else 
    Console.WriteLine("select month from 1 to 12");