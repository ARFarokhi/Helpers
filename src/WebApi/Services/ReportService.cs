using WebApi.Model;

namespace WebApi.Services
{
    public sealed class ReportService : IReportService
    {
        public List<CustomerDto> GetCustomers(string brokerCode)
        {
            return new List<CustomerDto>()
            {
                new CustomerDto() {Name = "John", LastName = "Smith", Age = 35},
                new CustomerDto() {Name = "Mary", LastName = "Smith", Age = 28}
            };
        }
    }
}
