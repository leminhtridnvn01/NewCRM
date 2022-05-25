namespace NewCRM.Repositories
{
    public interface ICustomerRepository<Customer> : IRepository<Customer> where Customer : class
    {
    }
}
