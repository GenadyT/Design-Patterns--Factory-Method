using FactoryMethod.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.DL
{
    public abstract class DataScope<T>
    {
        public T[] data { get; set; }
	}
}
