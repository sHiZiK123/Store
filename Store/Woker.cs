using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store {
    enum Speciality {
        Housewife,
        Builder,
        Sportsmen,
        Cook
    }

    class Woker:Person {
        Speciality cpeciality;

        public Speciality Cpeciality { get { return cpeciality; } set { cpeciality = value; } }
    }
}
