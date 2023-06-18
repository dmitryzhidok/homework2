Console.Write("max string: ");
string newtext = "23 3232 dsf213213423ww! dsf213213423ww! dsf213213423ww!";
var rebuiltText = newtext.Split(' ');
int[] countersArray = new int[rebuiltText.Length];
var maxValue = 0;
for (int i = 0; i < rebuiltText.Length; i++)
{
    var nearray = rebuiltText[i];
    var count = 0;
    if (countersArray[i] > count)
    {
        count = countersArray[i];
    }

    for (int j = 0; j < nearray.Length; j++)
    {
        if (nearray[ j] == '1')
        { count++; }
        else if (nearray[ j] == '2')
        { count++; }
        else if (nearray[ j] == '3')
        { count++; }
        else if (nearray[ j] == '4')
        { count++; }
        else if (nearray[ j] == '5')
        { count++; }
        else if (nearray[ j] == '6')
        { count++; }
        else if (nearray[ j] == '7')
        { count++; }
        else if (nearray[ j] == '8')
        { count++; }
        else if (nearray[j] == '9')
        { count++; }
        
    }
    if (count>maxValue)
    {
        maxValue=count;
    }
    countersArray[i] = count;
    

}
Console.WriteLine(maxValue);
for (int i = 0; i < countersArray.Length; i++)
{
    if (countersArray[i]==maxValue)
    {
        Console.WriteLine(rebuiltText[i]);
    }
}
Console.WriteLine("max word");

var maxValue2 = " ";
int count2 = 0;
foreach (var line in rebuiltText)
{
    if (line.Length > maxValue2.Length)
    {
        maxValue2 = line;

    }


}

for (var i = 0; i < rebuiltText.Length; i++)
{
    if (maxValue2 == rebuiltText[i])
    {
        count2++;
    }
}


Console.WriteLine($" maxValue={maxValue2} quantity={count2}");
Console.WriteLine();

Console.Write("words that start and end with the same letter: ");
for (int i = 0; i < rebuiltText.Length; i++)
{
    var MaxSimvols = rebuiltText[i];
    if (MaxSimvols[0] == MaxSimvols[MaxSimvols.Length - 2])
    {
        Console.WriteLine(MaxSimvols.Replace(',', ' ').Replace('.', ' ').Replace('?', ' ').Replace('!', ' '));
    }
}
Console.WriteLine();

Console.Write("replacing numbers with words: ");
var newzsd = newtext.Replace("0", "zero").Replace("1", "one").Replace("2", "two").Replace("3", "three").Replace("4", "four").Replace("5", "five").Replace("6", "six").Replace("7", "sever").Replace("8", "eight").Replace("9", "nine");
Console.WriteLine(newzsd);
Console.WriteLine();

Console.Write("first interrogative sentences, then exclamatory sentences: ");
for (int i = 0; i < rebuiltText.Length; i++)
{
    var Askstring = rebuiltText[i];

    if (Askstring[Askstring.Length - 1] == '?')
    {
        Console.WriteLine(Askstring);
    }

}
for (int i = 0; i < rebuiltText.Length; i++)
{
    var Askstring = rebuiltText[i];

    if (Askstring[Askstring.Length - 1] == '!')
    {
        Console.WriteLine(Askstring);
    }

}
Console.WriteLine();

Console.Write("all sentences except commas: ");
for (int i = 0; i < rebuiltText.Length; i++)
{
    var Askstring = rebuiltText[i];
    if (Askstring[Askstring.Length - 1] == ',')
    {
        continue;
    }
    else
    {
        Console.WriteLine(Askstring);
    }
}






