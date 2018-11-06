using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDB
{
    partial class Product
    {
        public override string ToString()
        {
            return string.Format("{0}", Name);
        }
    }
}
