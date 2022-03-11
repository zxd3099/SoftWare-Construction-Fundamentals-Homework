using System;

namespace Assignment3
{
    class ShapeTest
    {
        static string[] Shapes = { "Rectangle", "Triangle", "Square" };
        static void Main(string[] args)
        {
            double area = 0;
            Random rd = new Random();
            for (int i = 0; i < 10; i++)
            {
                string name = Shapes[rd.Next(0, 3)];
                Shape shape = ShapeFactory.CreateShape(name);
                if (shape.IsLegal()) area += shape.Area();
                else
                    throw new ArgumentException("Invalid input!"); 
            }
            Console.WriteLine($"The sum of area is: {area}\n");

        }
    }
    abstract class Shape
    {
        // Calculate the area
        public abstract double Area();
        // Determine if the shape is legal
        public abstract bool IsLegal();
    }
    class Rectangle : Shape
    {
        protected double _width;
        protected double _height;
        public double Width {
            get => _width;
            set => _width = value;
        }

        public double Height {
            get => _height;
            set => _height = value;
        }
        public Rectangle(double _width, double _height)
        {
            this._width = _width;
            this._height = _height;
        }
        public override double Area()
        {
            return Width * Height;
        }

        public override bool IsLegal()
        {
            return Width > 0 && Height > 0;
        }
    }

    class Square : Rectangle
    {
        public Square(double side):base(side, side)
        {
        }
        
    }

    class Triangle : Shape
    {
        private double _side1, _side2, _side3;

        public double Side1 {
            get => _side1;
            set => _side1 = value;
        }
        public double Side2
        {
            get => _side2;
            set => _side2 = value;
        }
        public double Side3
        {
            get => _side3;
            set => _side3 = value;
        }
        public Triangle(double _side1, double _side2, double _side3)
        {
            this._side1 = _side1;
            this._side2 = _side2;
            this._side3 = _side3;
        }
        public override double Area()
        {
            double p = (_side1 + _side2 + _side3) / 2;
            return Math.Sqrt(p * (p - _side1) * (p - _side2) * (p - _side3));
        }

        public override bool IsLegal()
        {
            return (_side1 + _side2 > _side3) && (_side1 + _side3 > _side2) && (_side2 + _side3 > _side1) && (_side1 > 0) && (_side2 > 0) && (_side3 > 0);
        }
    }

    class ShapeFactory
    {
        public static Shape CreateShape(string name)
        {
            name = name.ToLower();
            string[] input;
            double _width, _height, _side, _side1, _side2, _side3;
            switch (name)
            {
                case "rectangle":
                    Console.WriteLine("Input the side and height of the rectangle, like: 2 3. ");
                    input = Console.ReadLine().Split(' ');
                    if (input.Length != 2)
                        throw new ArgumentException("Invalid input!");
                    else
                    {
                        _width = double.Parse(input[0]);
                        _height = double.Parse(input[1]);
                    }
                    return new Rectangle(_width, _height);
                case "triangle":
                    Console.WriteLine("Input the three sides of the triangle, like: 2 3 2. ");
                    input = Console.ReadLine().Split(' ');
                    if (input.Length != 3)
                        throw new ArgumentException("Invalid input!");
                    else
                    {
                        _side1 = double.Parse(input[0]);
                        _side2 = double.Parse(input[1]);
                        _side3 = double.Parse(input[2]);
                    }
                    return new Triangle(_side1, _side2, _side3);
                case "square":
                    Console.WriteLine("Input the side of the square. ");
                    _side = double.Parse(Console.ReadLine());
                    return new Square(_side);
                default:
                    throw new ArgumentException("Invalid input!");
            }
        }
    }
}
