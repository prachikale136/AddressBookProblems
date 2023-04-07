namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the address Book System Problem");
            AddressBookMain addressBookMain = new AddressBookMain();

            Console.WriteLine("Enetr how many contact you want to add");
            int number = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= number; i++) 
            {
                addressBookMain.AddContact();
            
            }
           
            addressBookMain.PrintList();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Press 1 for Edit Contact, \n Press 2 for delete contact ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {

                case 1:
                    Console.WriteLine("Enter first name of contact to be edited");
                    string firstNameEditedContact = Console.ReadLine();
                    Console.WriteLine("Enter last name of contact to be edited");
                    string lastNameEditedContact = Console.ReadLine();
                    addressBookMain.Edit(firstNameEditedContact, lastNameEditedContact);
                    break;
                case 2:
                    Console.WriteLine("Enetr the name of contact to be deleted");
                    string firstNameDeletedContact = Console.ReadLine();
                    Console.WriteLine("Enter last name of contact to be deleted");
                    string lastNameDeletedContact = Console.ReadLine();
                    addressBookMain.DeleteContact(firstNameDeletedContact, lastNameDeletedContact);
                    break;
                default:
                    Console.WriteLine("Enetr valid choice");
                    break;
            }
            Console.ReadLine();
        }
        
    }
}