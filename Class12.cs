using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class12
    {
        /// <summary>
        /// Числитель
        /// </summary>
        int numerator;
        /// <summary>
        /// Знаменатель
        /// </summary>
        int denumerator;
        public Class12(int a) { numerator = a; denumerator = 1; }
        public Class12(int a, int b) { numerator = a; denumerator = b; }
        public Class12(int a, int b, int c) { numerator = a * c + b; denumerator = c; }
        public double ToFloat()
        {
            return (double)(numerator) / denumerator;
        }
    }
}
