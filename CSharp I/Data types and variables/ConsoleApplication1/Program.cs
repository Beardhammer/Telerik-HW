using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            static T AddIfIntegers<T>(T x, T y)
{
    if (typeof(T) == typeof(int))
    {
        int sum = __refvalue(__makeref(x), int) + __refvalue(__makeref(y), int);
        return __refvalue(__makeref(sum), T);
    }
    else
    {
        return default(T);
    }
}
        }
    }
}
