using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServicesPortal.Models;

namespace ServicesPortal.Repositories
{
    public interface ICommentRepository : IRepository<Comment>
    {
        /// <summary>
        /// Gets the comment by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Comment GetCommentById(int id);

        /// <summary>
        /// Determines whether [has user comment] [the specified user identifier].
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns>
        ///   <c>true</c> if [has user comment] [the specified user identifier]; otherwise, <c>false</c>.
        /// </returns>
        bool HasUserComment(int userId);
    }
}
