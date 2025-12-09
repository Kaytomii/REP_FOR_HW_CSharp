namespace HW4_09_12.Models
{
    public class SuperMarket
    {
        //fields
        private string? _store_name;
        private string? _address;
        private string? _description;
        private string? _contact_number;
        private string? _contact_email;

        //constructors
        public SuperMarket() { }
        public SuperMarket(string? store_name, string? address, string? description, string? contact_number, string? contact_email)
        {
            _store_name = store_name;
            _address = address;
            _description = description;
            _contact_number = contact_number;
            _contact_email = contact_email;
        }

        //getters
        public string? GetStore_Name()
        { return _store_name; }

        public string? GetAddress() 
        { return _address; }

        public string? GetDescription()
        { return _description; }

        public string? GetContact_Number() 
        { return _contact_number; }

        public string? GetContact_Email() 
        { return _contact_email; }

        //setters
        public void SetStoreName(string? store_name)
        { _store_name = store_name; }

        public void SetAddress(string? address) 
        { _address = address; }

        public void SetDescription(string? description)
        { _description = description; }

        public void SetContact_number(string? contact_number)
        { _contact_number = contact_number; }

        public void SetContact_email(string? contact_email)
        { _contact_email = contact_email; }

        //methods

        public void Fill_Store()
        {
            Console.Write("Enter store name: ");
            _store_name = Console.ReadLine();

            Console.Write("Enter address: ");
            _address = Console.ReadLine();

            Console.Write("Enter description: ");
            _description = Console.ReadLine();

            Console.Write("Enter phone number: ");
            _contact_number = Console.ReadLine();

            Console.Write("Enter email address: ");
            _contact_email = Console.ReadLine();
        }

        public void Print_Store()
        {
            Console.WriteLine($"The store name is: {GetStore_Name()}");
            Console.WriteLine($"Address is: {GetAddress()}");
            Console.WriteLine($"Description: {GetDescription()}");
            Console.WriteLine($"Phone number: {GetContact_Number()}");
            Console.WriteLine($"Email address: {GetContact_Email()}");
        }
    }
}
