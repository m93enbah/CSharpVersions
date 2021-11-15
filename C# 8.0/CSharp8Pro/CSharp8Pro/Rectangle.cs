using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8Pro
{
    public struct Rectangle
    {
        private double _height;
        public readonly double length { get; }

        public  double height {
            readonly get { 
                return _height; 
            } 
            set {
                _height = value; 
          } }

        //it will initialize one time when the constructor initialized 
        //it will make definsive copy so it will make protection level and
        //the system make copy instance of properties inside it that refer to properities of the struct
        public  readonly double Area() 
        {
            //you cannot change as below
            //height += 1;
            return length * height;
        }
    }
}
