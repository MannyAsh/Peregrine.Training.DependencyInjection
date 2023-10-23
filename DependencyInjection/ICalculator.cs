using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    internal interface ICalculator
    {
        public void Add(int a, int b);
        public void Divide(int a, int b);
    }
}
