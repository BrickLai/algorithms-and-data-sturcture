using System;
using System.Collections;
using System.Collections.Generic;

Console.WriteLine("------------1. Find the maximum number------------");
////1.MaxNumbersInLists(List<List<int>>) accepts as a parameter a List of Lists of Integers.
////It returns a new list with each element
////representing the maximum number found in the corresponding original list. 


//List<int> intNumberOne = new List<int>(){ 1, 3, 4, 5, 2, 1, 3 };


List<int> intNumberOne = new List<int>();
intNumberOne.AddRange(new int[] { 1, 5, 3 });
List<int> intNumberTwo = new List<int>();
intNumberTwo.AddRange(new int[] { 9, 7, 3, -2 });
List<int> intNumberThree = new List<int>();
intNumberThree.AddRange(new int[] { 2, 1, 2 });


int max1 = intNumberOne[0];
int max2 = intNumberTwo[0];
int max3 = intNumberThree[0];
//int max1=intNumberOne.Max();

for (int i = 0; i < intNumberOne.Count; i++)
{
    if (intNumberOne[i] > max1)
    {
        max1 = intNumberOne[i];
    }
}
for (int i = 0; i < intNumberTwo.Count; i++)
{
    if (intNumberTwo[i] > max2)
    {
        max2 = intNumberTwo[i];
    }
}
for (int i = 0; i < intNumberThree.Count; i++)
{
    if (intNumberThree[i] > max3)
    {
        max3 = intNumberThree[i];
    }
}


Console.WriteLine($"List 1 has a maximum of {max1},List 2 has a maximum of {max2}, List 3 has a maximum of {max3}.");




Console.WriteLine();
Console.WriteLine("------------2. Return the highest grade------------");
////2.String HighestGrade(List<List<int>>) accepts a list of number grades among students in different courses
////(where each list represents a single course), between 0 and 100.
////It returns the highest grade among all students in all courses.

List<int> intArrayOne = new List<int>();
intArrayOne.AddRange(new int[] { 85, 92, 67, 94, 94 });
List<int> intArrayTwo = new List<int>();
intArrayTwo.AddRange(new int[] { 50, 60, 57, 95 });
List<int> intArrayThree = new List<int>();
intArrayThree.AddRange(new int[] { 95 });

//Console.WriteLine(intArrayThree);
List<List<int>> intArrayMerged = new List<List<int>>();
intArrayMerged.Add(intArrayOne);
intArrayMerged.Add(intArrayTwo);
intArrayMerged.Add(intArrayThree);

int maxNumber = 0;
//Console.WriteLine(intArrayMerged);
for (int i = 0; i < intArrayMerged.Count; i++)
{

    for (int j = 0; j < intArrayMerged[i].Count; j++)
    {

        if (intArrayMerged[i][j] < maxNumber) ;
        {
            maxNumber = intArrayMerged[i][j];
        }
    }

}
Console.WriteLine($"The highest grade is {maxNumber}");


Console.WriteLine();
Console.WriteLine("------------3.sort the numbers from least to greatest------------");
////3.List<int> OrderByLooping (List<int>) orders a list of integers,
////from least to greatest, using only basic control statements (ie. if/else, for/while).

int[] order = { 6, -2, 5, 3 };

for (int i = 0; i < order.Length; i++)
{
    for (int j = 0; j < order.Length - 1; j++)
    {
        if (order[j] > order[j + 1])
        {
            int temp = order[j];
            order[j] = order[j + 1];
            order[j + 1] = temp;
        }
    }
}

for (int i = 0; i < order.Length; i++)
{
    Console.Write(order[i] + " ");
}


