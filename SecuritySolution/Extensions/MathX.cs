using System;

namespace Security.Extensions
{
    public static class MathX
    {
        public static int Gcd(int a, int b) => b == 0 ? a : Gcd(b, a % b);
    }
}
