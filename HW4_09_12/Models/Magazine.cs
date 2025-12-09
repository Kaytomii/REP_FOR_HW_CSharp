namespace HW4_09_12.Models
{
    public class Magazine
    {
        private string? name;
        private int year;
        private string? description;
        private string? contact_number;
        private string? contact_email;

        //constructor
        public Magazine() { }

        public Magazine(string? name, int year, string? description, string? contact_number, string? contact_email)
        {
            this.name = name;
            this.year = year;
            this.description = description;
            this.contact_number = contact_number;
            this.contact_email = contact_email;
        }

        //getters
        public string? GetName()
        { return this.name; }

        public int? GetYear()
        { return this.year; }

        public string? GetDescription()
        { return this.description; }

        public string? GetContact_number() 
        { return this.contact_number; }

        public string? GetContact_email() 
        { return this.contact_email; }

        //setters
        public void SetName(string? name)
        { this.name = name; }

        public void SetYear(int year)
        { this.year = year; }

        public void SetDescription(string? description)
        { this.description = description; }

        public void SetContactNumber(string? contact_number)
        { this.contact_number = contact_number; }

        public void SetContactEmail(string? contact_email)
        { this.contact_email = contact_email; }

        //methods
        public void Fill_Magazine()
        {
            Console.Write("Enter the name of the magazine: ");
            name = Console.ReadLine();

            Console.Write("Enter the year of publication: ");
            year = int.Parse(Console.ReadLine()!);

            Console.Write("Enter description: ");
            description = Console.ReadLine();

            Console.Write("Enter your phone number: ");
            contact_number = Console.ReadLine();

            Console.Write("Enter your email address: ");
            contact_email = Console.ReadLine();
        }

        public void Print_Magazine()
        {
            Console.WriteLine($"The Magazine name is : {GetName()}");
            Console.WriteLine($"Year of publication is: {GetYear()}");
            Console.WriteLine($"Description: {GetDescription()}");
            Console.WriteLine($"Phone number: {GetContact_number()}");
            Console.WriteLine($"Email address: {GetContact_email()}");
        }
    }
}
