namespace CollectionAddressBook
{
    public class Program
    {
        public static void Main(string[] args)
        {
           
            AddressBook Adr = new AddressBook();
            Adr.createUser();
            Adr.editContact();
            Adr.printUser();
        }
    }
}