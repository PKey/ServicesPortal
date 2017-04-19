using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServicesPortal.Models;

namespace ServicesPortal.Repositories
{
    /// <summary>
    /// Interface for services repository
    /// </summary>
    /// <seealso cref="ServicesPortal.Repositories.IRepository{ServicesPortal.Models.Service}" />
    public interface IServiceRepository : IRepository<Service>
    {
        /// <summary>
        /// Gets the service by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Service GetServiceById(int id);

        /// <summary>
        /// Determines whether [has user service] [the specified user identifier].
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns>
        ///   <c>true</c> if [has user service] [the specified user identifier]; otherwise, <c>false</c>.
        /// </returns>
        bool HasUserService(int userId);
    }
}
