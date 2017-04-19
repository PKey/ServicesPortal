using System.Linq;
using ServicesPortal.Models;

namespace ServicesPortal.Repositories.Interfaces
{
    /// <summary>
    /// Interface of customers repository
    /// </summary>
    /// <seealso cref="IRepository{T}.Models.Customer}" />
    public interface ICustomerRepository : IRepository<Customer>
    {
        /// <summary>
        /// Gets the customer by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Customer GetCustomerById(int id);

        /// <summary>
        /// Gets the customer by user identifier.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns></returns>
        Customer GetCustomerByUserId(int userId);

        /// <summary>
        /// Gets all customers with newsletter.
        /// </summary>
        /// <returns></returns>
        IQueryable<Customer> GetAllCustomersWithNewsletter();

        /// <summary>
        /// Determines whether the specified identifier is customer.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        ///   <c>true</c> if the specified identifier is customer; otherwise, <c>false</c>.
        /// </returns>
        bool IsCustomer(int id);

        /// <summary>
        /// Determines whether the specified identifier is confirmed.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        ///   <c>true</c> if the specified identifier is confirmed; otherwise, <c>false</c>.
        /// </returns>
        bool IsConfirmed(int id);
    }
}
