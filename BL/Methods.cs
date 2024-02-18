using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace BL
{
    public class Methods
    {
        public Methods()
        {

        }
        //Metoda zwracająca największą liczbę z trzech
        public int MaxNumber(int x, int y, int m)
        {
            int result = m;
            if(x > y && x > m)
                result = x;
            else if (y > m && y > x) 
                result = y;
            return result;
        }

        //Metoda sprawdzająca czy podana liczba jest parzysta
        public bool ParzystaLiczba(int a) => (a % 2 == 0) ? true : false;      

        //Metoda zwracająca sumę dwóch liczb, jeżeli są one większe od zera
        public int Sum(int x, int y) => (x + y) > 0 ? x + y : throw new Exception("nie spełnia warunku");

        // Metoda sprawdzająca czy podany rok jest rokiem przestępnym
        public int GetAbsoluteNumber(int num) => num < 0 ? -num : num;
    }
}
