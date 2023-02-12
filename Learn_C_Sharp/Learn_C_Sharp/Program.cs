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
    // 第2章 Chapter 2 ////////////////////////////////////////////////////////////////////////////

    // 問題2.1
    //var baseArray = new Song[2];
    //var array1 = new Song("リンダ リンダ", "THE BLUE HEARTS", 180);
    //var array2 = new Song("エイトビート", "ザ・クロマニヨンズ", 230);

    //baseArray[0] = array1;
    //baseArray[1] = array2;

    //baseArray[0].ConsoleResult();
    //baseArray[1].ConsoleResult();


    // 問題2.2  
    //new InchToMeter().ConsoleResult();


    // 第2章 Chapter 3 ////////////////////////////////////////////////////////////////////////////

    // 演習
        // Delegate型のメソッドの呼び出し
        //new DelayExeMethod().Execute();

        // 拡張メソッドの呼び出し
        /*var result = ExtensionMethod.Hoge("hoge");
        Console.WriteLine(result);*/

    // Question3.1
        //var numbers = new List<int> {10, 11, 16, 49, 50, 51, 102 };

        // 1
            //Console.WriteLine(numbers.Exists(x => x % 9 == 0) || numbers.Exists( x => x % 8 == 0));

            //numbers.ForEach(x =>
            //     {
            //         Console.WriteLine(x / 2.0);
            //     }
            // );

        // 2
            //var result = numbers.Where(x => x > 50);

            //foreach(var num in result)
            //{
            //    Console.WriteLine(num);
            //};

        
        // 3
            //var result2 = numbers.Select(x => x*2);
            //foreach(var num in result2) { 
            //    Console.WriteLine(num);
            //}

    // Qusetion3.2
        //var names = new List<string> { "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong"};

        // 1
            //var inputName = Console.ReadLine();
            //Console.WriteLine(names.FindIndex(x => x == inputName));
            
        // 2
        //static void Exercise2_2(List<string> names) {
        //    var count = names.Count(s => s.Contains('o'));
        //    Console.WriteLine(count);
        //}

        //static void Exercise2_3(List<string> names) {
        //    var selected = names.Where(s => s.Contains('o'))
        //                        .ToArray();
        //    foreach (var name in selected)
        //        Console.WriteLine(name);
        //}

        //static void Exercise2_4(List<string> names) {
        //    var selected = names.Where(s => s.StartsWith("B"))
        //                        .Select(s => s.Length);
        //    foreach (var length in selected)
        //        Console.WriteLine(length);
        //}
                
        

    }
}