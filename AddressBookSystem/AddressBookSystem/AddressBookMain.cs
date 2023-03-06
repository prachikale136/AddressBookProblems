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
       public List<Contact> contactList = new List<Contact>();  //here create a list for contact
        public void AddContact(string firstName, string lastName, string address, String city, string state, int zip, long phoneNumber, string email)
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
            //using for each loop caliinf the varilabe
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
         
        //method for EditContact
        public void Edit(string firstName, string lastName)
        {
            //create local variable for contact and initialize null
            Contact editedContact = null;

            foreach (Contact contact in contactList)
            {
                if (contact.firstName == firstName && contact.lastName == lastName)
                {
                    editedContact = contact;
                    
                }

                if (editedContact == null)
                {
                    Console.WriteLine("No such data exist");
                    return;
                }
                //otherwise get the edited contact
                this.EditContact(editedContact);
            }
            

        }

        //method for edit contact and get contact
        public void EditContact(Contact editedContact)
        {
            while (true)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Enter 1 for edit First Name");
                Console.WriteLine("Enter 2 for edit Last Name");
                Console.WriteLine("Enter 3 for edit Address");
                Console.WriteLine("Enter 4 for edit City");
                Console.WriteLine("Enter 5 for edit State");
                Console.WriteLine("Enter 6 for edit zip Code");
                Console.WriteLine("Enter 7 for edit Phone number");
                Console.WriteLine("Enetr 8 for edit Email");
                Console.WriteLine("Enter 9 if you are with editing");
                int check = Convert.ToInt32(Console.ReadLine());
                switch (check)
                {
                    case 1:
                        Console.WriteLine("Enter new name ");
                        string fName = Console.ReadLine();
                        editedContact.firstName = fName;
                        break;
                    case 2:
                        Console.WriteLine("Enter new last name");
                        string lName = Console.ReadLine();
                        editedContact.lastName = lName;
                        break;
                    case 3:
                        Console.WriteLine("ENter new Address");
                        string address = Console.ReadLine();
                        editedContact.address = address;
                        break;
                    case 4:
                        Console.WriteLine("Enetr new city");
                        string city = Console.ReadLine();
                        editedContact.city = city;
                        break;
                    case 5:
                        Console.WriteLine("Enter new state");
                        string state = Console.ReadLine();
                        editedContact.state = state;
                        break;
                    case 6:
                        Console.WriteLine("Enter new zip");
                        int zip = Convert.ToInt32(Console.ReadLine());
                        editedContact.zip = zip;
                        break;
                    case 7:
                        Console.WriteLine("Enetr new phone number");
                        long phoneNumber = Convert.ToInt64(Console.ReadLine());
                        editedContact.phoneNumber = phoneNumber;
                        break;
                    case 8:
                        Console.WriteLine("Enter new emailid");
                        string email = Console.ReadLine();
                        editedContact.email = email;
                        break;
                    case 9:
                        Console.WriteLine("editing done");
                        //if editing is done then get the values from printEditContact
                       this.PrintEditContact(editedContact);
                        return;
                }
                
            }

        }

        public void PrintEditContact(Contact contact)
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("First Name :" + " " + contact.firstName);
            Console.WriteLine("LastNAme:" + " " + contact.lastName);
            Console.WriteLine("Address:" + " " + contact.address);
            Console.WriteLine("City:" + " " + contact.city);
            Console.WriteLine("State:" + " " + contact.state);
            Console.WriteLine("zip:" + " " + contact.zip);
            Console.WriteLine("PhoneNumber:" + " " + contact.phoneNumber);
            Console.WriteLine("Email:" + " " + contact.email);

        }

        // method for delete contact
        public void DeleteContact(string firstName, string lastName)
        {
            Contact deletedContact = null;
            foreach(Contact contact in contactList) 
            {
                if(contact.firstName == firstName && contact.lastName ==lastName) 
                {
                    deletedContact= contact;
                    this.contactList.Remove(contact);
                    break;
                }
            }
            if(deletedContact == null)
            {
                Console.WriteLine("No such contact exist");
            }
            else
            {
                Console.WriteLine("deletion done");
            }
        }

    }
}
