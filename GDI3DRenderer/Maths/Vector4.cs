using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDI3DRenderer.Maths
{
    public class Vector4
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public double W { get; set; }

        public Vector4(double x, double y, double z, double w = 1.0)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        public double Length3D()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }

        public static Vector4 operator *(Vector4 a, double scalar)
        {
            a.X *= scalar;
            a.Y *= scalar;
            a.Z *= scalar;

            return a;
        }

        public static double operator *(Vector4 a, Vector4 b)
        {
            return a.X * b.X + a.Y * b.Y + a.Z * b.Z;
        }

        public static Vector4 operator *(Matrix4x4 a, Vector4 b)
        {
            b.X = a.M11 * b.X + a.M12 * b.Y + a.M13 * b.Z + a.M14 * b.W;
            b.Y = a.M21 * b.X + a.M22 * b.Y + a.M23 * b.Z + a.M24 * b.W;
            b.Z = a.M31 * b.X + a.M32 * b.Y + a.M33 * b.Z + a.M34 * b.W;
            b.W = a.M41 * b.X + a.M42 * b.Y + a.M43 * b.Z + a.M44 * b.W;

            return b;

        }

        public static Vector4 operator *(Vector4 b, Matrix4x4 a)
        {
            return a * b;
        }

        public static Vector4 operator +(Vector4 a, Vector4 b)
        {
            a.X += b.X;
            a.Y += b.Y;
            a.Z += b.Z;

            return a;
        }


        public static Vector4 operator -(Vector4 a)
        {
            a.X = -a.X;
            a.Y = -a.Y;
            a.Z = -a.Z;

            return a;
        }
        public static Vector4 operator -(Vector4 a, Vector4 b)
        {
            a.X -= b.X;
            a.Y -= b.Y;
            a.Z -= b.Z;

            return a;
        }

        public override string ToString()
        {
            return "[{" + X + ", " + Y + ", " + Z + ", " + W + "}]";
        }
    }
}
