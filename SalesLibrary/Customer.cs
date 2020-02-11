using System;
using System.Collections.Generic;
using System.Text;

namespace TernaryAccessModifier {
    public class Customer {

        private static int NextId = 1;//after each instance will increment everyone will share this one value
        //dont always want to start at one. how would you deal with starting with last one
        public int Id { get; set; }//get and set are standins for code 
        public string Name { get; set; }
        private bool IsNationalAccount { get; set; }
        private static int DiffId;

        //static constructor-set static data, can have params  like a default 
        static Customer() {
            //read file to get the next id to be assigned
            NextId = 21;//this would be one more than what was read in 
            //runs as soon as you reference class 

            
        }

        public override string ToString() {
            //shows me the customer varialbe
            //helpful enhcancement for debugging
            //can call it from program with Console.WriteLine(cust1);
            return $"Id ={this.Id}, name={this.Name}, NAacct={this.IsNationalAccount} ";
        }

        public void NationalAccount (string yesOrNo) {
            //just looking at first letter only looking for y or n, throw others away
            //this.IsNationalAccount = yesOrNo.StartsWith("y");
            //if look for "yes" use
            this.IsNationalAccount = yesOrNo.Equals("yes") ? true : false;

        }

        public static string PrintNextId() {
            return $"next id is {NextId}";
            
        }
        //constructor for next id
        public Customer(string Name) {
            this.Id = NextId;//take off this to be part of class and not an instance
            this.Name = Name;
            NextId++;
            //this.Id = DiffId;
            //DiffId++;
        }
    }
}
