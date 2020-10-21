using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Big_Domashka
{
    class ShoppingCart
    {

        public Guid id;
        private byte capacity = 50;
        public List<Product> listOfOrderItems = new List<Product>();
        
    }
}
