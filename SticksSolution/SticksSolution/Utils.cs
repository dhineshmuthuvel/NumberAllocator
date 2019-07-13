using System.Collections.Generic;

namespace SticksSolution
{
    public class Utils
    {
        public static List<int> Split(int count, int parts)
        {
            List<int> result = new List<int>();
            if (count % parts == 0)
            {
                for (int i = 0; i < parts; i++)
                {
                    result.Add(count/parts);
                }
            }
            else
            {
                int zp = (count % parts);
                count = count - (count % parts);
                int pp = count / parts;
                for (int i = 0; i < parts; i++)
                {
                    if (zp > 0)
                    {
                        result.Add(pp + 1);
                        zp--;
                    }
                    else
                    {
                        result.Add(pp);
                    }
                }
            }

            return result;
        }
    }
}