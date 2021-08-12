using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charp200_beginner_WPF
{
    class Rectangle69
    {
        private double width;
        private double height;

        public double GetWidth69()  // Getter
        {
            return width;
        }

        public double GetHeight69()
        {
            return height;
        }

        public void SetWidth69(double width)   // Setter
        {
            if (width > 0)
                this.width = width;
        }

        public void SetHeight69(double height)
        {
            if (height > 0)
                this.height = height;
        }
    }

    class RectWithProp69
    {
        public double Width { get; set; }  // Width 속성
        public double Height { get; set; } // Height 속성
    }

    class RectWithPropFull69
    {
        private double width;
        public double Width
        {
            get { return width; }
            set { if (value > 0) width = value; }
        }

        private double height;
        public double Height
        {
            get { return height; }
            set { if (value >= 0) height = value; }
        }
    }


    class _69_Class
    {
    }
}
