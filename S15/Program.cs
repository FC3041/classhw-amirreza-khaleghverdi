using System.Globalization;
using System.Numerics;

namespace S15;

class Program
{
    static void swap <T>(ref T a,ref T b)
    {
        T temp =a;
        a=b;
        b=temp;
    }

    static T average<T> (T a,T b) where T: INumber<T>
    {
        return (a+b);
    }

    static void printItems<T> ()
    
}
