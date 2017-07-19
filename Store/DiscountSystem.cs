using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class DiscountSystem:IntelligentSystem {
        List<NameOfProduct> discountsList=new List<NameOfProduct>();
        List<int> discountValues = new List<int>();

        public void AddDiscount(NameOfProduct productName, int disc) {
            discountsList.Add(productName);
            discountValues.Add(disc);
        }
        
        List<Product> SetNewPrice(List<Product> _productsList) {
            List<Product> tempList = new List<Product>();
            foreach(var parametr in _productsList)
                if (discountsList.Contains(parametr.NameProduct)) {
                    parametr.Price=parametr.Price-(parametr.Price*(discountValues[discountsList.IndexOf(parametr.NameProduct)] * 0.01));
                    tempList.Add(parametr);
                }
                else
                    tempList.Add(parametr);
            return tempList;
        }

        public override Dictionary<string, List<Product>> GetProductsListForPerson(List<Buyer> clients, List<Product> _productsList) {
            Dictionary<string, List<Product>> temp = base.GetProductsListForPerson(clients, SetNewPrice(_productsList));
            foreach (var parametr in clients) {
                Console.Write("Products for {0}: \n", parametr.FirstName);
                foreach (var parametr1 in temp[parametr.FirstName])
                    if(discountsList.Contains(parametr1.NameProduct))
                    Console.WriteLine("{0} Price ({1}% discount): {2}", parametr1.NameProduct, 
                        discountValues[discountsList.IndexOf(parametr1.NameProduct)], parametr1.Price);
                else
                        Console.WriteLine("{0} Price: {1}", parametr1.NameProduct, parametr1.Price);
            }
            return temp;
        }
    }
}
