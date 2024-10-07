using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice15
{
    class AppleBox
    {
        public Apple Apple { get; set; } 
        public int Length { get; set; }
        public int Width { get; set; }
        public double Depth { get; set; }

        public AppleBox()
            : this(1,1,1,new Apple()){}
        public AppleBox(int lenght, int width, double depth, Apple apple)
        {
            Length = lenght;
            Width = width;
            Depth = depth;
            Apple = apple;
        }

        public static AppleBox operator +(AppleBox a, AppleBox b)
        {
            Apple apple = new Apple();
            //was thinking about how can i append two objects,
            //decided to just add their only properties
            apple.Name = a.Apple.Name + " , " + b.Apple.Name; 
            AppleBox appleBox = new AppleBox()
            {
                Length = a.Length + b.Length,
                Width = a.Width + b.Width,
                Depth = a.Depth + b.Depth,
                Apple = apple
            };
            return appleBox;
        }

        public static AppleBox operator -(AppleBox a, AppleBox b)
        {
            AppleBox appleBox = new AppleBox()
            {
                Length = a.Length - b.Length,
                Width = a.Width - b.Width,
                Depth = a.Depth - b.Depth
            };
            return appleBox;
        }

        public override string ToString()
        {
            return String.Format("This box of apples has {0} lenght, {1} width, {2} depth. Contains next apple(s): {3}", Length, Width, Depth, Apple.Name);
        }

        public static explicit operator int(AppleBox box)
        {
            return (int)(box.Length + box.Width + box.Depth + Convert.ToInt32(box.Apple.Name.Count()));
        }

        public static implicit operator AppleBox(int i)
        {
            return new AppleBox(i, i, i, new Apple($"{i}"));
        }
    }
}
