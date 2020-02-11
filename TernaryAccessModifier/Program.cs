using System;

namespace TernaryAccessModifier {
    class Program {
        static void Main(string[] args) {

            //can print off next id to show even though in customer
            Console.WriteLine(Customer.PrintNextId()) ;
            Console.WriteLine($"the cube of 17 is {cubed(17)}");

            //need to create a customer and an order and
            //order is going to use customer

            var cust1 = new Customer ( "Max Technical Training" );
            cust1.NationalAccount("yes");
           
            Console.WriteLine(cust1);//works but won't be helpful prints name of class but 
            //make a method override in customerer to do this
            var cust2 = new Customer ( "Amazon" );
            Console.WriteLine(cust2);
            var cust3 = new Customer ( "Target" );
            Console.WriteLine(cust3);

            cust1.NationalAccount("yes");

            //create our order
            //var order1 = new Order { Id = 1, Amount = 1000, Customer = cust1};since added in order
            //have to change to 
            var order1= new Order { Amount = 1000, Customer = cust1 };

            var order2 = new Order { Amount = 300, Customer = cust2 };

            static int cubed(int nbr) {
                return nbr * nbr * nbr;
            }
        }
    }
}
