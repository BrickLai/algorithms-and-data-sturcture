using System.Text.RegularExpressions;

Console.WriteLine("Please decide how many words you want to enter, please input the number here:");
int wordsNumber = Convert.ToInt32(Console.ReadLine());

while (wordsNumber <= 0)
{
    Console.WriteLine("sorry, please enter a positive value");
    wordsNumber = Convert.ToInt32(Console.ReadLine());
}

int wordContent = wordsNumber;
string[] words = new string[wordContent];

for (int n = 0; n < wordContent; n++)
{
    string word = "";
    while (word.Length < 1)
    {
        Console.WriteLine($"Please enter word {n + 1}");
        word = Console.ReadLine();
    }
    words[n] = word;
}

// Get the words string
Console.WriteLine("You entered these words:");
//string enterWords = string.Join(',', words);
string enterWords = string.Concat(words);
Console.WriteLine(enterWords);

// Count the times of the character
Console.WriteLine("Please enter a character that you want to count:");
string myChar = Console.ReadLine();
int count1 = enterWords.Length - enterWords.Replace(myChar, "").Length;
//Console.WriteLine(count1);

// Get the length of the string
int wordsLength = enterWords.Length;
// Console.WriteLine(wordsLength);

// Get the percentage of the character in the string
Console.WriteLine($"The character of '{myChar}' occurs {count1} time(s)");
double percentage = count1 * 1.0 / wordsLength;
Console.WriteLine("That character represents {0:0.00}% of the entire string", percentage * 100);
