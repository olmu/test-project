namespace TestProject.Contracts.Requests
{
    public class GetCustomerBalanceRequest
    {
        public string CustomerId { get; set; }
    }

    public class GetCustomerBalanceResponse
    {
        public int Balance { get; set; }
    }
}
