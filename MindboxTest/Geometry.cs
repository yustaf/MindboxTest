using System;

namespace MindboxTest
{
    public static class Geometri
    {
        public static bool CheckSideTriangle (double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                return false;
            if ((sideA + sideB < sideC) || (sideA - sideB > sideC) || (sideB - sideA > sideC))
                return false;
            return true;
        }
        public static bool CheckTriangleRightAngle(double sideA, double sideB, double sideC)
        {
            var A = Math.Pow(sideA, 2);
            var B = Math.Pow(sideB, 2);
            var C = Math.Pow(sideC, 2);
            if( (A + B == C) || ( A + C == B) || (B + C == A))
                return true;
            return false;
        }
        public static double Perimeter (double sideA = 0, double sideB = 0, double sideC = 0, double sideD = 0, double radius = 0)
        {
            if (radius > 0)
                return 2 * Math.PI * radius;

            return sideA + sideB + sideC + sideD;
        }
        #region Area
        public static double AreaTriangle (double sideA, double sideB, double sideC)
        {
            if (!CheckSideTriangle(sideA, sideB, sideC))
                throw new ArgumentException("Wrong sides");
            var Semiperimeter = Perimeter(sideA, sideB, sideC)/2;
            var Area = Math.Sqrt(Semiperimeter * (Semiperimeter - sideA) * (Semiperimeter - sideB) * (Semiperimeter - sideC));
            return Area;
        }
        public static double AreaCircle (double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Wrong radius");
            return Math.PI * Math.Pow(radius,2); 
        }
        public static double AreaSquare (double sideA, double sideB)
        {
            if (sideA <= 0 && sideB <= 0)
                return -1;
            return sideA * sideB;
        }
        public static double AreaAllFigure (double sideA = 0, double sideB = 0, double sideC = 0, double sideD = 0, double h = 0, double radius = 0)
        {
            double Area = -1;
            if(radius>0)
                Area = AreaCircle(radius);
            if (Area > 0) return Area;

            if (sideA>0 && sideB>0 && sideC>0)
                Area = AreaTriangle(sideA, sideB, sideC);
            if (Area > 0) return Area;

            if (sideA > 0 && sideB > 0)
                Area = AreaSquare(sideA, sideB);
            if (Area > 0) return Area;

            throw new ArgumentException("Wrong figure");
        }
#endregion
    }
}
