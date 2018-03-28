namespace MockClassLibrary.CustonerForMoq
{
    public class Customer
    {
        public Customer(string fn, string ln)
        {
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address MailingAddress { get; set; }
        public string WorkspaceName { get; internal set; }
        public int? WorkstationId { get; internal set; }

    }
}
