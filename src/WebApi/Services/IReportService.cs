using WebApi.Model;

namespace WebApi.Services;

public interface IReportService
{
    List<CustomerDto> GetCustomers(string brokerCode);
}