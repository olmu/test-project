using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.BL.Requests
{
    public class GetCustomerBalanceBlRequest
    {
        public string CustomerId { get; set; }
    }

    public class GetCustomerBalanceBlResponse
    {
        public int Balance { get; set; }
    }
}
