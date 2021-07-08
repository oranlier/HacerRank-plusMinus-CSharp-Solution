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

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        double say_pozitif=0;
        double say_negatif=0;
        double say_sifir=0;

        foreach (var item in arr)
        {
            if (item<0)
            {
                say_negatif+=1;
            }
            else if (item>0)
            {
                say_pozitif+=1;
            }
            else
            {
                say_sifir +=1;
            }
        }
        
        Console.WriteLine(string.Format("{0:0.0000}", say_negatif / arr.Count));
        Console.WriteLine(string.Format("{0:0.0000}", say_pozitif / arr.Count));
        Console.WriteLine(string.Format("{0:0.0000}", say_sifir / arr.Count));
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
