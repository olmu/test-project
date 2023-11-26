namespace TestProject.Contracts.Requests
{
    public class RegisterCustomerRequest
    {
        public string Name { get; set; }
        public uint Age { get; set; }
    }

    public class RegisterCustomerResponse
    {
        public string CreatedCustomerId { get; set; }
    }
}
