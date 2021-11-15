using System.Collections.Generic;
using System.Linq;

namespace ExpressionBoidedFuncPro
{
    //we can use expression boided function over many types such as property , methods , indexer ,etc...
    public class Employee
    {
        //1-Properities and fields
        public decimal BasePrice, Taxes;
        public decimal TotalPrice => BasePrice + Taxes;
        //its equivalent to
        //public decimal TotalPrice{get{return BasePrice + Taxes;}}

        //2-Indexers 
        public Dictionary<string, string> lstKeys = new Dictionary<string, string>();
        public object this[string key] => lstKeys[key];
        //its equivalent to
        //public object this[string key]{get{return dictionary[key];}}

        //3-Methods
        static int Multiply(int a, int b) => a * b;
        //its eqivalent to
        //static int Multiply(int a, int b){return a * b; }


        //limitations
        //expression function can't contain block statements and any other statements that contain blocks: if, switch, for, foreach, while, do, try, etc.
        IEnumerable<string> Digits => Enumerable.Range(0, 10).Select(i => i.ToString());
        //its eqivalent to
        //IEnumerable<string> Digits{get{for (int i = 0; i < 10; i++)yield return i.ToString();}}
    }
}
