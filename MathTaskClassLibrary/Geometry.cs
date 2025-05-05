using System;

namespace MathTaskClassLibrary
{
    public class Geometry
    {
        public int S(int a, int b)
        {
            return a * b; // Метод вычисления площади
        }

        public int P(int a, int b)
        {
            return 2 * (a + b); // Метод вычисления периметра
        }

        public double V(double r, double h)
        {
            const double PI = 3.14; // Приближение числа Пи
            return PI * r * r * h; // Формула объёма цилиндра: π * r² * h
        }

        public int ParallelepipedVolume(int a, int b, int c)
        {
            return a * b * c; // Формула объёма параллелепипеда: a * b * c
        }

        public int ParallelepipedSurfaceArea(int a, int b, int c)
        {
            return 2 * (a * b + b * c + a * c); // Формула площади поверхности: 2(ab + bc + ac)
        }
    }
}