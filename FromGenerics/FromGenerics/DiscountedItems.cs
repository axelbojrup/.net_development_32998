using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromGenerics
{
    public class DiscountedItems<TProduct> where TProduct : Product
    {
        public int CalculateAfterSale(TProduct pro)
        {
            //pro.Price


            return 0;
        }

    }
}
