using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store {
    class OurStore {
        List<Product> productsList;
        List<Buyer> clients;
        IntelligentSystem cleverSystem = new IntelligentSystem();
        DiscountSystem discountSystem = new DiscountSystem();

        public void GetResult() {
            InicializeClientsList();
            InicializeProductsList();
            //cleverSystem.GetProductsListForPerson(clients, productsList);
            discountSystem.AddDiscount(NameOfProduct.Ball, 2);
            discountSystem.AddDiscount(NameOfProduct.Bananas, 1);
            discountSystem.GetProductsListForPerson(clients, productsList);
        }

        void InicializeClientsList() {
            clients = new List<Buyer>();
            clients.Add(new Buyer("Mary", 25, 2000, Speciality.Housewife));
            clients.Add(new Buyer("Peter", 23, 500, Speciality.Builder));
            clients.Add(new Buyer("Mike", 28, 500, Speciality.Sportsmen));
            clients.Add(new Buyer("Kate", 30, 400, Speciality.Cook));
        }

        void InicializeProductsList() {
            productsList = new List<Product>();
            productsList.Add(new Product { NameProduct = NameOfProduct.Ball, Price = 10 });
            productsList.Add(new Product { NameProduct = NameOfProduct.Bananas, Price = 20 });
            productsList.Add(new Product { NameProduct = NameOfProduct.Oven, Price = 1000 });
            productsList.Add(new Product { NameProduct = NameOfProduct.SetOfBricks, Price = 100 });
        }
    }
}
