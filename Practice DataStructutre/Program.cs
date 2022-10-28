// See https://aka.ms/new-console-template for more information
using Practice_DataStructutre;
using System.Collections;

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


var arr = new Array<int>(15);

arr.AAdd(1);
arr.AAdd(2);
arr.AAdd(3);
arr.Remove(2);

Console.WriteLine(arr.ToString());