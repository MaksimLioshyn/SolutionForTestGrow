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
        public Address Email { get; set; }

    }
}
