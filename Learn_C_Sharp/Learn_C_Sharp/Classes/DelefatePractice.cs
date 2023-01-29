using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_C_Sharp.Classes
{
    public class DelefatePractice
    {
        // このDelegateの定義によってJudgment型の変数には、intを受け取ってbool値を返すメソッドを代入できる
        public delegate bool Judgment(int value);

        public void CallDelegateMethod()
        {
            var numbers = new[] { 5, 4, 3, 2, 1, };
            Judgment judge = IsEven;
           
        }

        // Deleteに代入する予定のメソッド
        public bool IsEven (int n)
        {
            return n % 2 == 0;
        }

        // このメソッドはDelete型の変数には代入できない
        public string ReturnString(int n)
        {
            return n.ToString();
        }

        // ラムダ式を使ったメソッド

    }
}
