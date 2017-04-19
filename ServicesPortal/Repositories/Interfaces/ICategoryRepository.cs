using System.Linq;
using ServicesPortal.Models;

namespace ServicesPortal.Repositories.Interfaces
{
    /// <summary>
    /// Interface of categories repository
    /// </summary>
    /// <seealso cref="IRepository{T}.Models.Category}" />
    public interface ICategoryRepository : IRepository<Category>, IRepository<CommentCategory>
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
