Console.WriteLine("------------1. characters appear more than once------------");
////1 A program that produces an array of all of the characters
////that appear more than once in a string.
Console.WriteLine("Please enter a phrase");
string str = Console.ReadLine();

char[] ch = str.ToCharArray();
var groups = str.GroupBy(v => v);
foreach (var group in groups)
    if (group.Count() > 1)
    {
        Console.WriteLine(group.Key);
    }

Console.WriteLine();
Console.WriteLine("------------2.unique words --------------------------------");

////2 A program returns an array of strings
////that are unique words found in the argument.
Console.WriteLine("Please enter a string");
string strTwo = Console.ReadLine();
string[] strTwoArray = strTwo.Split(" ");
string wordStrTwo = "";

for (int i = 0; i < strTwoArray.Length; i++)
{
    int indexOne = Array.IndexOf(strTwoArray, strTwoArray[i]);
    int indexTwo = Array.LastIndexOf(strTwoArray, strTwoArray[i]);
    if (wordStrTwo.IndexOf(strTwoArray[i]) == -1)
    {
        wordStrTwo += strTwoArray[i] + ",";
    }
}

string[] wordStringArray = wordStrTwo.Split(",");

foreach (string singleWord in wordStringArray)
{
    Console.Write($"{singleWord} ");
}


Console.WriteLine();
Console.WriteLine("------------3.reversed--------------------------------");
//3 reversed
Console.WriteLine("Please enter a string");
string strThree = Console.ReadLine();
char[] chThree = strThree.ToCharArray();

//Console.WriteLine(chThree.Length);
for (int i = chThree.Length; i > 0; i--)
{
    Console.WriteLine(chThree[i - 1]);

}
//string strThreeFinal=new string(chThree);
//Console.WriteLine(strThreeFinal);


Console.WriteLine();
Console.WriteLine("------------4.find the longest unbroken word----------------");

////4 A program that finds the longest unbroken word
////in a string and prints it
Console.WriteLine("Please enter a string");
string strFour = Console.ReadLine();
string[] words = strFour.Split(' ');

foreach (var word in words)
{
    Console.WriteLine($"{word}");
}

var shortString = words[0];
var longString = words[0];

foreach (var t in words)
{
    if (longString.Length < t.Length)
        longString = t;
}

Console.WriteLine("Longest string is " + longString);



