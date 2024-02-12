namespace BL
{
    public class NieparzysteLiczby
    {
        public static int NieparzysteLiczbyTablicy(int[] array)
        {
            int count = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                    count++;    
            }

            return count;
        }
    }
}
