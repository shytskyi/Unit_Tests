namespace BL
{
    public  class Culculator
    {
        public static float DodawaniaLiczby(float x, float y)
        {
            return (float)(x + y);
        }

        public static double DzieleniaLiczb(double x, double y)
        {
            if (y == 0)
                throw new DivideByZeroException();

            return x / y;
        }
    }
}
