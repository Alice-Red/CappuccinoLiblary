using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cappuccino.Util
{
    public struct Formula
    {
        public double Result { get; private set; }

        private Formula(double n) {
            Result = n;
        }

        public Formula Add(double n) {
            Result += n;
            return this;
        }

        public Formula Sub(double n) {
            Result -= n;
            return this;
        }

        public Formula Mul(double n) {
            Result *= n;
            return this;
        }

        public Formula Div(double n) {
            if (n != 0)
                Result /= n;
            else
                throw new DivideByZeroException();
            return this;
        }

        public Formula Func(Func<double, double> a) {
            Result = a(Result);
            return this;
        }
    }
}
