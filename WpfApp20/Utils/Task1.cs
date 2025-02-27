using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task1
    {
        public static string Calculate(int A, int B, int C)
        {
            string resultA = (A % 2 == 0 && B % 2 != 0) || (A % 2 != 0 && B % 2 == 0)
                ? "a) Только одно их чисел A и B четное"
                : "a) Оба числа четны или не четны";

            string resultB = (A % 3 == 0) && (B % 3 == 0) && (C % 3 == 0)
                ? "b) Каждое из чисел A, B, C кратно 3-м"
                : "b) По крайней мере одно из чисел не кратно 3-м";

            return $"{resultA}\n{resultB}";
        }
    }
}
