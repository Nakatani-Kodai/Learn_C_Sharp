using Learn_C_Sharp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    static void Main(string[] args)
    {
        // 第2章 ////////////////////////////////////////////////////////////////////////////

            // 問題2.1
            var baseArray = new Song[2];
            var array1 = new Song("リンダ リンダ", "THE BLUE HEARTS", 180);
            var array2 = new Song("エイトビート", "ザ・クロマニヨンズ", 230);

            baseArray[0] = array1;
            baseArray[1] = array2;

            baseArray[0].ConsoleResult();
            baseArray[1].ConsoleResult();


            // 問題2.2  
            new InchToMeter().ConsoleResult();

    }
}