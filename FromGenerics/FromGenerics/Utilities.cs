using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromGenerics
{
    // 5 types of constraints. 
    // where T : IComparable  --> constraint to interface
    // where T : Product  --> If T is a product or any of it's children or sub-classes
    // where T : struct --> T should be value type 
    // where T : class --> T should be reference type
    // where T : new()  --> T is an object that has a default constructure 


    public class Utilities<T> where T :  IComparable , new() // struct
    {
        public int Max(int a, int b)
        {
            return ( a>b ) ? a : b ;
        }

        public void doJob(T value)
        {
            var obj = new T();
        }
        /*public T Max<T>(T a, T b) where T : IComparable
        {
            return (a.CompareTo(b)>0) ? a  : b ;
        }*/
    }
}
