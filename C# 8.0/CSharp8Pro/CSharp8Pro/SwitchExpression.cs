using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8Pro
{
    public class SwitchExpression
    {

        public static double DoMath(double x, double y, MathType mathType) 
        {
            //Swith Expression
            var output = mathType switch
            {
                MathType.Add => x + y,
                MathType.Subtract => x - y,
                MathType.Divide => x / y,
                MathType.Multiply => x * y,
                _ => throw new Exception("Bad Operation")
            };


            //Switch Statment
            //double output = 0;
            //switch (mathType)
            //{
            //    case MathType.Add:
            //        output = x + y;
            //        break;
            //    case MathType.Subtract:
            //        output = x - y;
            //        break;
            //    case MathType.Multiply:
            //        output = x * y;
            //        break;
            //    case MathType.Divide:
            //        output = x / y;
            //        break;
            //    default:
            //        throw new Exception("Bad Operation");
            //}
            return output;
        }






        
    }

    public enum MathType 
    {
        Add,
        Subtract,
        Multiply,
        Divide,

    }


}
