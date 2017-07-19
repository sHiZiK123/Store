using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store {
    class Buyer:Woker {
        int money;

        public int AmountOfMoney { get { return money; } set { money = value; } }

        public Buyer(string name, int age, int _money, Speciality cpeciality) {
            FirstName = name;
            Age = age;
            Cpeciality = cpeciality;
            money = _money;
        }
    }
}
