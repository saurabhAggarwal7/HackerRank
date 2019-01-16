using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Program
{

    // Complete the twoStrings function below.
    static string twoStrings(string s1, string s2)
    {
        //string[] s1_array = new string[] { s1 };
        //string[] s2_array = new string[] { s2 };

        //Array.Sort(s1_array);
        //Array.Sort(s2_array);

        char[] chars_1 = s1.ToCharArray();
        char[] chars_2 = s2.ToCharArray();

        for (int i = 0; i < chars_1.Length; i++)
        {
            if (chars_2.Contains(chars_1[i]))
            {
                return "Yes";
            }
        }
        return "No";

    }

    static void Main(string[] args)
    {
        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s1 = Console.ReadLine();

            string s2 = Console.ReadLine();

            string result = twoStrings(s1, s2);

            Console.Out.WriteLine(result);
        }

        Console.Out.Flush();
        Console.Out.Close();
    }
}
