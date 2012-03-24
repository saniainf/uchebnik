#define EXPERIMENTAL
#define TRIAL
//#define NODEFINE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Chapter2
{
    public Chapter2()
    {
#if EXPERIMENTAL
        Console.WriteLine("compile experimental version");
#endif

#if EXPERIMENTAL && TRIAL
        Console.WriteLine("compile trial experimental version");
#endif

#if NODEFINE
        Console.WriteLine("no compile");
#else
        Console.WriteLine("nodef else");
#endif

        Console.WriteLine("all version");
    }
}

