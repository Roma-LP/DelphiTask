using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15.Functions
{
    public class BaseFunction : Function
    {
        public override string Title => "Base function";
        public override double F(double x) => x;
    }
}
