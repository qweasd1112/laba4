using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZashitaInformacii4Lab
{
    class RandomGenerator
    {
        private int A;
        private int C;
        private int startValue;
        private int lastValue;
        private int B;

        public RandomGenerator(int B)
        {
            A = 17;
            C = 11;
            startValue = 10;
            this.B = B;
            lastValue = startValue;
        }

        public int next()
        {
            int temp = (A * lastValue + C) % B;
            lastValue = temp;
            return temp;
        }
    }
}
