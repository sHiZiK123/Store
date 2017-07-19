using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store {
    class Person {
        string firstName;
        int age;

        public string FirstName { get { return firstName; } set { firstName = value; } }
        public int Age { get { return age; } set { age = value; } }
    }
}
