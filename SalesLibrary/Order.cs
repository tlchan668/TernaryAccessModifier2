using System;
using System.Collections.Generic;
using System.Text;

namespace TernaryAccessModifier {
    public class Order {

        private static int lastId = 0;
       
        
        public int Id { get; private set; }
        public double Amount{ get; set; }
        public Customer Customer { get; set; }

        //create method 
        static Order() {//don't have to do but if have to go read it then would need to do this
            lastId = 0;
        }

        public void SetCustomer(Customer customer) {
            this.Customer = customer;
        }

        public Order() {
            this.Id = lastId += 7;
        }
        public string toConsole() {
            return $"Order ID {Id}, Amount[{Amount}]";
        }
    }
}
