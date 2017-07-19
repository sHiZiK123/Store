using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store {
    class IntelligentSystem {
        List<Product> productsList = new List<Product>();
        Dictionary<Speciality, List<Product>> dictionary = new Dictionary<Speciality, List<Product>>();

        
        double GetPrise(NameOfProduct name) {
            foreach(var parametr in productsList)
                if (parametr.NameProduct == name) return parametr.Price;
            return 0;
        }


        void SetDictionary(List<Buyer> clients) {          
            dictionary.Add(Speciality.Cook, new List<Product> {
                new Product { NameProduct = NameOfProduct.Oven, Price = GetPrise(NameOfProduct.Oven) },
                new Product { NameProduct = NameOfProduct.Bananas, Price = GetPrise(NameOfProduct.Bananas) }
            });
            
            dictionary.Add(Speciality.Housewife, new List<Product> {
                 new Product { NameProduct = NameOfProduct.Oven, Price = GetPrise(NameOfProduct.Oven) },
                new Product { NameProduct = NameOfProduct.Bananas, Price = GetPrise(NameOfProduct.Bananas) }
            });
            
            dictionary.Add(Speciality.Builder, new List<Product> {
                new Product { NameProduct = NameOfProduct.SetOfBricks, Price=GetPrise(NameOfProduct.SetOfBricks) }
            });
            
            dictionary.Add(Speciality.Sportsmen, new List<Product> {
                new Product { NameProduct = NameOfProduct.Bananas, Price = GetPrise(NameOfProduct.Bananas) },
                new Product { NameProduct = NameOfProduct.Ball, Price = GetPrise(NameOfProduct.Ball) }
            });
        }



        public virtual Dictionary<string, List<Product>> GetProductsListForPerson(List<Buyer> clients, List<Product> _productsList) {
            List<Product> productList;
            productsList = _productsList;
            Dictionary<string, List<Product>> temp = new Dictionary<string, List<Product>>();

            SetDictionary(clients);

            foreach(var parametr in clients) {
                productList = new List<Product>();
                if (dictionary.ContainsKey(parametr.Cpeciality)) {
                    foreach (Product paramentr1 in dictionary[parametr.Cpeciality]) {
                        if (parametr.AmountOfMoney >= paramentr1.Price)
                      productList.Add(paramentr1);
                    }
                         temp.Add(parametr.FirstName, productList);
                }
            }

            return temp;
           // foreach (var parametr in clients) {
           //     Console.Write("Products for {0}: \n", parametr.FirstName);
           //     foreach (var parametr1 in temp[parametr.FirstName])
           //         Console.WriteLine("{0} Price: {1}", parametr1.NameProduct, parametr1.Price);
           // }    
        }
    }
}
