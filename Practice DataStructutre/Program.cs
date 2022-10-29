// See https://aka.ms/new-console-template for more information
using Practice_DataStructutre;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Xml;

//Console.WriteLine("Hello, World!");
//Hashtable my_hashtable = new Hashtable();

//// Adding key/value pair in the hashtable
//// Using Add() method
//my_hashtable.Add("A1", "Welcome");
//my_hashtable.Add("A2", "to");
//my_hashtable.Add(1, "GeeksforGeeks");
//my_hashtable.Add(2, "GeeksforGeeks");


//foreach (DictionaryEntry element in my_hashtable)
//{
//    Console.WriteLine("Key:- {0} and Value:- {1} ",
//                       element.Key, element.Value);
//}


//Stack myStack = new Stack();
//myStack.Push("Hello");
//myStack.Push("World");
//myStack.Push(1);

//// Displays the properties and values of the Stack.
//Console.WriteLine("myStack");
//Console.WriteLine("\tCount:    {0}", myStack.Count);
//Console.Write("\tValues:");
//PrintValues(myStack);

// static void PrintValues(IEnumerable myCollection)
//{
//    foreach (Object obj in myCollection)
//        Console.Write("    {0}", obj);
//    Console.WriteLine();
//}


//var arr = new Array<int>(15);

//arr.AAdd(1);
//arr.AAdd(2);
//arr.AAdd(3);
//arr.Remove(2);

//Console.WriteLine(arr.ToString());

//int[] arr1 = new int[4];

//int[] arr2 = {6,7,8,9,10,11,12};
//arr1 = arr2;
//int[] cars = new int[4] { 1, 2, 3,4 };


//Console.WriteLine(arr1.ToString());
int[] nums = { 0, 0, 1};
var x= Solution.RemoveDuplicates(nums);
Console.WriteLine(x);
public static class Solution
{
    public static int RemoveDuplicates(int[] nums)
    {
        int len = nums.Length;
        int j = 0;
        if (len == 0 || len == 1)
            return len;



        for (int i = 0; i < len - 1; i++)
            if (nums[i] != nums[i + 1])
                nums[j++] = nums[i];

        nums[j++] = nums[len - 1];

        return j;



    }
}


