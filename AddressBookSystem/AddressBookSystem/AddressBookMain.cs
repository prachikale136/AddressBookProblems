using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class AddressBookMain
    {
       public static List<Contact> contactList = new List<Contact>();  //here create a list for contact
        public static void AddContact(string firstName, string lastName, string address, String city, string state, int zip, long phoneNumber, string email)
        {
            Contact contact = new Contact();  // create object of contact class


            // calling variables by using object
             contact.firstName = firstName;
             contact.lastName = lastName;
            contact.address = address;
            contact.city = city;
            contact.state = state;
            contact.zip = zip;
            contact.phoneNumber = phoneNumber;
            contact.email = email;
            contactList.Add(contact);

        }

        //method to print Conatct List

         public void PrintList()
        {
            Console.WriteLine("---------------------------------------------------");
            foreach (Contact contact in contactList)
            {

                Console.WriteLine("First Name :" + " " + contact.firstName);
                Console.WriteLine("LastNAme:" + " " + contact.lastName);
                Console.WriteLine("Address:" + " " + contact.address);
                Console.WriteLine("City:" + " " + contact.city);
                Console.WriteLine("State:" + " " + contact.state);
                Console.WriteLine("zip:" + " " + contact.zip);
                Console.WriteLine("PhoneNumber:" + " " + contact.phoneNumber);
                Console.WriteLine("Email:" + " " + contact.email);

            }



        }
    }
}
