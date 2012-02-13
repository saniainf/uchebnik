using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

delegate void StrMod2(ref string str);


class Chapter2
{
    public Chapter2()
    {
        DelegateTestRef delegateObj = new DelegateTestRef();
        StrMod2 strOp;
        StrMod2 replaceSp = delegateObj.ReplaceSpaces;
        StrMod2 removeSp = delegateObj.RemoveSpace;
        StrMod2 reverseStr = delegateObj.Reverse;
        string str = "Simple string line";

        strOp = replaceSp;
        strOp += reverseStr;

        strOp(ref str);
        Console.WriteLine("str: " + str + "\n");

        strOp -= replaceSp;
        strOp += removeSp;
        str = "Simple string line";

        strOp(ref str);
        Console.WriteLine("str: " + str + "\n");
    }
}

class DelegateTestRef
{
    public void ReplaceSpaces(ref string s)
    {
        Console.WriteLine("replace space 2 defic");
        s = s.Replace(' ', '-');
    }

    public void RemoveSpace(ref string s)
    {
        string temp = "";
        int i;

        Console.WriteLine("del space");
        for (i = 0; i < s.Length; i++)
        {
            if (s[i] != ' ') temp += s[i];
        }
        s = temp;
    }

    public void Reverse(ref string s)
    {
        string temp = "";
        int i, j;

        Console.WriteLine("reverse string");
        for (j = 0, i = s.Length - 1; i >= 0; i--, j++)
            temp += s[i];
        s = temp;
    }
}