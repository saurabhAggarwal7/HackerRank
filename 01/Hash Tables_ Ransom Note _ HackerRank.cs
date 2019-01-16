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

class Solution {

    // Complete the checkMagazine function below.
    static void checkMagazine(string[] magazine, string[] note) {
        
        

        var diff = magazine.Intersect(note);
        if(diff.Count() == note.Count()){
        Console.WriteLine("Yes");
        } else{
        Console.WriteLine("No");
        }
		
		// List<string> magzineList = magazine.ToList();
        // List<string> noteLst = note.ToList();

        // var grp1 = magzineList.GroupBy(a => a);
        // var grp2 = noteLst.GroupBy(a.Key => a);

        // bool flag = false;
        // foreach (var grp in grp2)
        // {
        //     if (grp1.Contains(grp))
        //     {
        //         Console.WriteLine("No");
        //         break;
        //     }
        // }
        // Console.WriteLine("Yes");

        // var keysDictionary2HasThat1DoesNot = noteLst.Except(magzineList).ToList();
        // if(keysDictionary2HasThat1DoesNot.Count() > 0){
        //     Console.WriteLine("No");
        // }
        // else{
        //     Console.WriteLine("Yes");
        // }

        // HashSet<int> magSet = new HashSet<int>();
        // HashSet<int> noteSet = new HashSet<int>();

        // for (int i = 0; i < magazine.Count(); i++)
        // {
        //     magSet.Add(i);
        // }

        // for (int i = 0; i < note.Count(); i++)
        // {
        //     noteSet.Add(i);
        // }
        // var diff = magSet.Except(noteSet);
        // if (diff.Count() > 0)
        // {
        //     Console.WriteLine("No");
        // }
        // else
        // {
        //     Console.WriteLine("Yes");
        // }



    }

    static void Main(string[] args) {
        string[] mn = Console.ReadLine().Split(' ');

        int m = Convert.ToInt32(mn[0]);

        int n = Convert.ToInt32(mn[1]);

        string[] magazine = Console.ReadLine().Split(' ');

        string[] note = Console.ReadLine().Split(' ');

        checkMagazine(magazine, note);
    }
}
