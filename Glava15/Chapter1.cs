﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

delegate string StrMod(string str);


class Chapter1
{
    public Chapter1()
    {
        var delegObj = new DelegateTest();
        string str;

        var strOp = new StrMod(delegObj.ReplaceSpaces);
        str = strOp("Test string line");
        Console.WriteLine("str: " + str + "\n");

        strOp = delegObj.RemoveSpace;
        str = strOp("Test string line");
        Console.WriteLine("str: " + str + "\n");

        strOp = delegObj.Reverse;
        str = strOp("Test string line");
        Console.WriteLine("str: " + str + "\n");
    }
}

class DelegateTest
{
    public string ReplaceSpaces(string s)
    {
        Console.WriteLine("replace space 2 defic");
        return s.Replace(' ', '-');
    }

    public string RemoveSpace(string s)
    {
        string temp = "";
        int i;

        Console.WriteLine("del space");
        for (i = 0; i < s.Length; i++)
        {
            if (s[i] != ' ') temp += s[i];
        }
        return temp;
    }

    public string Reverse(string s)
    {
        string temp = "";
        int i, j;

        Console.WriteLine("reverse string");
        for (j = 0, i = s.Length - 1; i >= 0; i--, j++)
            temp += s[i];
        return temp;
    }
}

