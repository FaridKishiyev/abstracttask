using System;
using System.Collections.Generic;
using System.Text;

namespace abstracttask.Models
{
    class Rectangular : Figure
    {
        private int width;
        private int length;


        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value > 0)
                {
                    width = value;

                }

            }
        }



        public int Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value > 0)
                {
                    length = value;

                }

            }

        }

        public Rectangular(int width, int length)
        {
            this.Width = width;
            this.Length = length;
        }

        public override int CalcArea()
        {
            return this.Width * this.Length;
        }
    }
}
