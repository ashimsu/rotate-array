using System;
using System.Collections.Generic;
using System.Linq;

/// rotate array A by K positions

namespace s01rotate
{
    class Solution
    {
        public int[] solution(int[] A, int K)
        {
            if (K > A.Length) 
                throw new ArgumentException($"K cannot be more then {A.Length}");

            else if (K == 0 ||  K == A.Length)
                return A;

            var ret = new List<int>();
            ret.AddRange(A[^K .. ]);
            ret.AddRange(A[0 .. ^K]);

            int i = 0;
            foreach(var x in ret) 
                A[i++] = x; 
        
         return A;
        } 

    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new();

            int K = 3;
            int[] arr = {1, 2, 3, 4};

            Console.WriteLine($"before: " + string.Join(' ', arr));

            int [] res = s.solution(arr, K);

            Console.WriteLine($"after (K = {K}): " + string.Join(' ', res));

            System.Console.WriteLine("test: the same array was transformed arr[0] = 111");  
            res[0] = 111;
            Console.WriteLine($"res: " + string.Join(' ', res));
            Console.WriteLine($"arr: " + string.Join(' ', arr));
        }
    }
}
