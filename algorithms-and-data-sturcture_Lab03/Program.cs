Console.WriteLine("------------1. characters appear twice------------");
////1 Find the elements that appeared twice in O(n) time.
int[] intArrayOne = { 2, 3, 4, 7, 9, 2, 4, 1, 2 };

for (int i = 0; i < intArrayOne.Length; i++)
{
    intArrayOne[intArrayOne[i] % intArrayOne.Length]
        = intArrayOne[intArrayOne[i] % intArrayOne.Length]
        + intArrayOne.Length;
}
Console.WriteLine("The repeating elements are : ");
for (int i = 0; i < intArrayOne.Length; i++)
{
    if (intArrayOne[i] >= intArrayOne.Length * 2)
    {
        Console.Write(i + " ");
    }
}

Console.WriteLine();
Console.WriteLine("------------2. Merge arrays and keep the result array sorted------------");
//// merge them in a third array while keeping this result array sorted


int[,] intArrayTwo =
    {
    { 1, 2, 3, 4, 5 },
    { 2, 5, 7, 9, 13 }
    };

//Console.WriteLine(sum(intArrayTwo,[]));
// Console.WriteLine(String.Join(",", intArrayTwo));

//int[] intArrayThree = new int[10];
List<int> intArrayThree = new List<int>();


foreach (int i in intArrayTwo)
{
    //  Console.Write("{0} ", i);
    intArrayThree.Add(i);
}

//foreach (int i in intArrayThree)
//{
//    Console.WriteLine(i);
//}

for (int i = 0; i < intArrayThree.Count; i++)
{
    for (int j = 0; j < intArrayThree.Count - 1; j++)
    {
        if (intArrayThree[j] > intArrayThree[j + 1])
        {
            int temp = intArrayThree[j];
            intArrayThree[j] = intArrayThree[j + 1];
            intArrayThree[j + 1] = temp;
        }
    }
}

for (int i = 0; i < intArrayThree.Count; i++)
{
    Console.Write(intArrayThree[i] + " ");
}




Console.WriteLine();
Console.WriteLine("------------3. reverse the digits of that integer------------");
//3.Given an integer, reverse the digits of that integer,
//e. g. input is 3415, output is 5143.
//What is the time complexity of your solution?

Console.WriteLine("Please enter a number");
int numberThree = int.Parse(Console.ReadLine());
string strThree = numberThree.ToString();
char[] charsArray = strThree.ToCharArray();
//Console.WriteLine(charsArray[2]);

for (int i = charsArray.Length - 1; i >= 0; i--)
{
    Console.Write(charsArray[i]);
}