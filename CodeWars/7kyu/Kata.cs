﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars._7kyu
{
    //    Given the triangle of consecutive odd numbers:
    //             1
    //          3     5
    //       7     9    11
    //   13    15    17    19
    //21    23    25    27    29
    //...
    //Calculate the row sums of this triangle from the row index (starting at index 1) e.g.:
    //rowSumOddNumbers(1); // 1
    //rowSumOddNumbers(2); // 3 + 5 = 8
    class Kata
    {
        public static long rowSumOddNumbers(long n)
        {
            return n*n*n;
        }
    }
}
