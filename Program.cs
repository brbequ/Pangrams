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

class Solution
{
    // A pangram is a string that contains every letter of the alphabet.
    // Given a sentence determine whether it is a pangram in the English
    // alphabet. Ignore case. Return either pangram or not pangram as appropriate.

    // Complete the pangrams function below.
    static string pangrams(string s)
    {
        bool[] found = new bool[26];

        foreach(char c in s)
        {
            if (char.IsLetter(c))
            {
                found[char.ToLower(c) - 'a'] = true;
            }
        }

        foreach(bool b in found)
        {
            if (!b)
                return "not pangram";
        }

        return "pangram";
    }

    static void Main(string[] args)
    {
        string[] input = new string[]
        {
            "We promptly judged antique ivory buckles for the next prize",
            "We promptly judged antique ivory buckles for the prize"
        };

        foreach(string s in input)
        {
            string result = pangrams(s);
            Console.WriteLine(result);
        }
    }
}
