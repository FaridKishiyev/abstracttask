using System;
using System.Collections.Generic;
using System.Text;

namespace abstracttask.Models
{
    class Square : Figure
    {
        private int side;
        public int Side
        {
            get
            {
                return side;
            }
            set
            {
                if (value > 0)
                {
                    side = value;

                }

            }
        }

        public Square(int side)
        {
            this.Side = side;
        }

        public override int CalcArea()
        {
            return side * side;
        }
    }
}
