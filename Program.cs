namespace CollectionAddressBook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Address Book Problem Using Collection");
            AddressBook Adr = new AddressBook();
            Adr.createUser();
            Adr.printUser();
        }
    }
}