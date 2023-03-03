namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the address Book System Problem");
            AddressBookMain addressBookMain= new AddressBookMain();
            addressBookMain.AddContact("prachi", "kale", "bhf", "Nagpur", "MH", 441804, 01234456789, "abc@gmail.com");
            addressBookMain.PrintList();
            Console.ReadLine();
        }
    }
}