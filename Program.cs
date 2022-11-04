using System;

namespace CodeChallengeTaiwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num =  {5,3,6,1,12};  int  original =3;
            foreach(int elements in num)
            {   original++;
                if (elements < original)
                {
                    Console.WriteLine(2*original);
                }
                else
                {
                    Console.WriteLine(original);
                }
            }

        }
    }
}
