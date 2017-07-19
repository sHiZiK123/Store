using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store {
    enum NameOfProduct {
        Ball,
        Bananas,
        SetOfBricks,
        Oven
    }

    class Product {
        double price;
        NameOfProduct nameProduct;

        public double Price { get { return price; } set { price = value; } }
        public NameOfProduct NameProduct { get { return nameProduct; } set { nameProduct = value; } }
    }
}
