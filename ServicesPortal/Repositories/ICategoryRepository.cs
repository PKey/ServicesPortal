using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServicesPortal.Models;

namespace ServicesPortal.Repositories
{
    /// <summary>
    /// Interface of categories repository
    /// </summary>
    /// <seealso cref="ServicesPortal.Repositories.IRepository{ServicesPortal.Models.Category}" />
    public interface ICategoryRepository : IRepository<Category>
    {
        /// <summary>
        /// Gets all categories.
        /// </summary>
        /// <returns></returns>
        IQueryable<Category> GetAllCategories();

        /// <summary>
        /// Gets the category by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Category GetCategoryById(int id);

        /// <summary>
        /// Gets all comment categories.
        /// </summary>
        /// <returns></returns>
        IQueryable<CommentCategory> GetAllCommentCategories();

        /// <summary>
        /// Gets the comment category by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        CommentCategory GetCommentCategoryById(int id);
    }
}
