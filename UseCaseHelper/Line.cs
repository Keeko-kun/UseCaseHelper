using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace UseCaseHelper
{
    public class Line
    {
        private int x1;
        private int y1;
        private int x2;
        private int y2;

        public Line(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public Point FirstPoint
        {
            get
            {
                return new Point(x1, y1);
            }
        }
        public Point SecondPoint
        {
            get
            {
                return new Point(x2, y2);
            }
        }

    }
}
