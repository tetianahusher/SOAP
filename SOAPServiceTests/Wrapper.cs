using SOAPServiceTests.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOAPServiceTests
{
    public class MulWrapper
    {
        private CalcSEIClient calc;

        public MulWrapper()
        {
            calc = new CalcSEIClient();
        }

        public double Mul(double a, double b)
        {
            return calc.mul(a, b);
        }
    }
}
