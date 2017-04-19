using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServicesPortal.Models;

namespace ServicesPortal.Repositories
{
    public interface IServiceProviderRepository : IRepository<ServiceProvider>
    {

        /// <summary>
        /// Gets the service provider by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        ServiceProvider GetServiceProviderById(int id);

        /// <summary>
        /// Gets the service provider by user identifier.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns></returns>
        ServiceProvider GetServiceProviderByUserId(int userId);

        /// <summary>
        /// Gets the service providers.
        /// </summary>
        /// <returns></returns>
        IQueryable<ServiceProvider> GetServiceProviders();

        /// <summary>
        /// Gets all service providers with newsletter.
        /// </summary>
        /// <returns></returns>
        IQueryable<ServiceProvider> GetAllServiceProvidersWithNewsletter();

        /// <summary>
        /// Determines whether [is service provider] [the specified identifier].
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        ///   <c>true</c> if [is service provider] [the specified identifier]; otherwise, <c>false</c>.
        /// </returns>
        bool IsServiceProvider(int id);

        /// <summary>
        /// Determines whether the specified identifier is confirmed.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        ///   <c>true</c> if the specified identifier has confirmed account; otherwise, <c>false</c>.
        /// </returns>
        bool IsConfirmed(int id);


    }
}
