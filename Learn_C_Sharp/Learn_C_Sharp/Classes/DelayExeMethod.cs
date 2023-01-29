using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_C_Sharp.Classes
{
    public class DelayExeMethod
    {
        public void Execute()
        {
            string[] names = { "Tokyo", "London", "Paris","Hokkaido"};

            var query = names.Where(s => s.Length <= 5);

            foreach(var item in query)
                Console.WriteLine(item);
                Console.WriteLine("-------");

            names[0] = "Osaka";

            foreach (var item in query)
                Console.WriteLine(item);

            // 表示される結果はそれぞれ異なる。
            // Whereメソッドは15行目で実行されず、必要な時に呼び出される。
        }
    }
}
