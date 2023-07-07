using System.Collections;

namespace С__Pack
{
    public class DecimalNumber
    {
        public int Value { get; }

        public DecimalNumber(int value)
        {
            Value = value;
        }

        public string ToBinary()
        {
            return Convert.ToString(Value, 2);
        }

        public string ToOctal()
        {
            return Convert.ToString(Value, 8);
        }

        public string ToHexadecimal()
        {
            return Convert.ToString(Value, 16);
        }
    }
    public class Vector3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Vector3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Vector3D Multiply(double scalar)
        {
            return new Vector3D(X * scalar, Y * scalar, Z * scalar);
        }

        public Vector3D Add(Vector3D otherVector)
        {
            return new Vector3D(X + otherVector.X, Y + otherVector.Y, Z + otherVector.Z);
        }

        public Vector3D Subtract(Vector3D otherVector)
        {
            return new Vector3D(X - otherVector.X, Y - otherVector.Y, Z - otherVector.Z);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What exercise do you want to see? 1-3:");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        Vector3D v1 = new Vector3D(1, 2, 3);
                        Vector3D v2 = new Vector3D(4, 5, 6);

                        Vector3D resultMultiply = v1.Multiply(2);
                        Console.WriteLine($"Result of Multiplying: ({resultMultiply.X}, {resultMultiply.Y}, {resultMultiply.Z})");

                        Vector3D resultAdd = v1.Add(v2);
                        Console.WriteLine($"Result of Adding: ({resultAdd.X}, {resultAdd.Y}, {resultAdd.Z})");

                        Vector3D resultSubtract = v1.Subtract(v2);
                        Console.WriteLine($"Result of Subtract: ({resultSubtract.X}, {resultSubtract.Y}, {resultSubtract.Z})");

                        break;
                    }
                case 2:
                    {
                        DecimalNumber decimalNumber = new DecimalNumber(42);

                        string binary = decimalNumber.ToBinary();
                        Console.WriteLine($"BINARY: {binary}");

                        string octal = decimalNumber.ToOctal();
                        Console.WriteLine($"OCTAL: {octal}");

                        string hexadecimal = decimalNumber.ToHexadecimal();
                        Console.WriteLine($"HEXADECIMAL: {hexadecimal}");
                        break;
                    }
                case 3:
                    {
                        break;
                    }
            }
        }
    }
}
