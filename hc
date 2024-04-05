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

public static int twoTwo(string a){
    int pow = 0;
    BigInteger l = a.Length;
        for(BigInteger i =0;i<l;++i){
            if (a[i]!='0') {
            if(IsPower(int.Parse(a[i].ToString()))){
                pow++;
            }
            string new_String = a[i].ToString();
            for(BigInteger j=i+1;j<l;++j){
                new_String += a[j];
                if(IsPower(int.Parse(new_String))){
                pow++;
            }
            
            }
            }
        }
        return pow <= 800 ? pow : 0;
}
static bool IsPower(BigInteger x){
    while(x > 0 && x % 2 == 0){
        x -= x/2;
    }
    return x == 1 ? true : false;
}
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string a = Console.ReadLine();

            int result = Result.twoTwo(a);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
