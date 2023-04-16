namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Assignment\AddressBookProblems\AddressBookSystem\AddressBookSystem\file.txt";
            Console.WriteLine("Welcome to the address Book System Problem");
            AddressBookMain addressBookMain = new AddressBookMain();
            PersonContactFile personContactFile = new PersonContactFile();
            Console.WriteLine("Enetr how many contact you want to add");
            int number = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= number; i++) 
            {
                addressBookMain.AddContact();
            
            }
           
            addressBookMain.PrintList();
            Console.WriteLine("-----------------------------------------");
            bool flag = true;
            while(flag) 
            {
                Console.WriteLine("Press 1 for Edit Contact, \n Press 2 for delete contact, \n press 3 for searching, \n Press 4 for view Conatct \n press 5 for count \n press 6 for sort person by name \n press 7 for file exist or not \n press 8 for write data into file \n press 9 for read data from file");
                int choice = Convert.ToInt32(Console.ReadLine());

                List<Contact> ContactList = null;
                switch (choice)
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
                    case 3:
                        addressBookMain.Search();
                        break;
                    case 4:
                        addressBookMain.ViewContact();
                        break;
                    case 5:
                        addressBookMain.CountContact();
                        break;
                    case 6:
                        addressBookMain.SortByPersonName();
                        break;
                    case 7:
                        personContactFile.FileExistOrNot(path);
                        break;
                    case 8:
                        addressBookMain.WriteContactIntoFile(ContactList);
                        break;
                    case 9:
                        addressBookMain.ReadContactFromFile(ContactList);
                        break;


                    default:
                        flag= false;
                        break;
                }
                Console.ReadLine();
            }
            
        }
        
    }
}