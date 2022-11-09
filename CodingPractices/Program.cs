using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractices
{
    public class Program
    {
        static void Main(string[] args)
        {


        }
        /// <summary>
        /// It is good practice to start with an uppercase when naming a method
        /// </summary>
        /// 
        ///<code>
        ///static void NamedMethod()
        ///{
           /// Console.WriteLine("Method");
        ///}
    /// </code>

    /// <summary>
    /// Use Meaningful, descriptive or self-explanatory words to name variables.
    ///Avoid abbreviations
    /// </summary>
    /// <param name=""></param>
    ///<code>
    ///static void NamingConvention(string name)
    ///{
    ///     string FullName = "Edeh Israel Chidera";
    ///}
    /// </code>


    /// <summary>
    /// When naming class, use Pascal convention of naming classes
    /// </summary>
    ///<code>
    ///public class UserList
    ///{

    ///}
    /// </code>

    /// <summary>
    /// When naming Boolean variables, prefix it with
    /// “is” or some
    /// </summary>
    ///<code>
    ///bool isUserList = true;
    /// </code>

    /// <summary>
    /// It is good practice to 
    /// Use String.Empty instead of “” - an empty string        
    /// </summary>
    ///<code>
    ///static void Name()
    ///{
    ///string firstName = "";
    ///if (firstName == String.Empty)
    ///{
    /// Console.WriteLine(firstName);
    ///}
    ///}
    /// </code>

    /// <summary>
    /// Always use Pascal casing when naming a struct
    /// </summary>
    ///<code>
    ///public struct ValueCoordinate
    ///{
    ///}
    /// </code>

    /// <summary>
    /// When naming an interface, it is good coding practices
    /// to use pascal casing
    /// in addition to prefixing the name with an I. 
    /// This clearly indicates to consumers that it's an interface.
    /// </summary>
    ///<code>
    ///public interface IWorkerQueue
    ///{
    ///}
    /// </code>


    /// <summary>
    /// Use camel casing ("camelCasing") when naming private
    /// or internal fields, and prefix them with _.
    /// </summary>
    ///<code>
    ///public class DataService
    ///{
    ///     private IWorkerQueue _workerQueue;
    ///}
    /// </code>


    /// <summary>
    /// When working with static fields, it is a good practice that fields that are 
    /// private or internal, use the s_ prefix and for thread static use t_.
    /// </summary>
    ///<code>
    ///public class DataService1
    ///{
    /// private static IWorkerQueue s_workerQueue1;

    ///[ThreadStatic]
    ///private static TimeSpan t_timeSpan1;
    ///}
    /// </code>

    /// <summary>
    /// When writing method parameters, use camel casing.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="someNumber"></param>
    /// <param name="isValid"></param>
    /// <returns></returns>
    ///<code>
    ///public T SomeMethod<T>(int someNumber, bool isValid)
    ///{
    ///
    ///}
    /// </code>

    /// <summary>
    /// Write only one statement per line.
    /// </summary>
    ///<code>
    ///static void someFunction()
    ///{
    /// int number = 5;
    ///string name = "israel";
    ///}
    /// 
    /// </code>


    /// <summary>
    /// Use parentheses to make clauses in an 
    /// expression apparent, as shown in the following code.
    /// </summary>
    ///<code>
    ///static void someFunction1()
    ///{
    /// int val1 = 1;
    ///int val2 = 2;
    ///int val3 = 3;
    /// if ((val1 > val2) && (val1 > val3))
    ///{
    // Take appropriate action.
    ///}
    ///}
    /// 
    /// </code>


    /// <summary>
    /// It is good coding practices to append strings in loops, 
    /// especially when you're working 
    /// with large amounts of text, use a StringBuilder object.
    /// </summary>
    ///<code>
    ///static void someFunction2()
    ///{
    /// string longPhrase = "lalalalalalalalalalalalalalalalalalalalalalalalalalalalalala";
    ///StringBuilder manyPhrases = new StringBuilder();
    /// for (var i = 0; i< 10000; i++)
    ///{
    /// manyPhrases.Append(longPhrase);
    ///}
}
    /// </code>


    /// <summary>
    /// It is good coding practice to use a try-catch statement 
    /// for most exception handling.       
    /// </summary>
    /// <param name="array"></param>
    /// <param name="index"></param>
    /// <returns></returns>
    ///<code>
    ///static string GetValueFromArray(string[] array, int index)
    ///{
    /// try
    ///{
    /// return array[index];
    ///}
    ///catch (System.IndexOutOfRangeException ex)
    ///{
    /// Console.WriteLine("Index is out of range: {0}", index);
    ///throw;
    ///}
    ///}
    /// </ode>

    /// <summary>
    /// It is good practice to use string interpolation only to 
    /// concatenate short strings
    /// </summary>
    ///<code>
    ///static void someFunction3()
    /// {
    ///    string nameList = "JohnDoe";
    ///   string displayName = $"{nameList[n].LastName}, {nameList[n].FirstName}";
    ///}
    /// 
    /// </code>


}
}
