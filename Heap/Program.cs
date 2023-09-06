using System;

//ref link:https://www.youtube.com/watch?v=o4nM7itG6s8&list=PLRwVmtr-pp07XP8UBiUJ0cyORVCmCgkdA&index=39
//  Heap -- 
// LIFO -- last in first out

class CountingClass
{
    static short counter = 0;
    short id;
    char c;
    public CountingClass()
    {
        id = counter;
        c = (char)(((short)'a') + counter);
        counter++;
    }
}

class MainClass
{
    static void Main()
    {
        GC.Collect();
        var c1 = new CountingClass();
        var c2 = new CountingClass();
        new CountingClass();    // for GC
        new CountingClass();    // for GC
        var c5 = new CountingClass();
        GC.Collect();
    }
}