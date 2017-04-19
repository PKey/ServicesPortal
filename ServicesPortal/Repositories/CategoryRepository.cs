using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServicesPortal.Models;
using ServicesPortal.Models.Database;
using ServicesPortal.Repositories.Interfaces;

namespace ServicesPortal.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private ServicesPortalContext _db;

        public CategoryRepository()
        {
            _db = new ServicesPortalContext();
        }

        public void Add(Category category)
        {
            _db.Categories.Add(category);
        }

        public void Delete(Category category)
        {
            _db.Categories.Remove(category);
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }

        public IQueryable<Category> GetAllCategories()
        {
            return _db.Categories;
        }

        public Category GetCategoryById(int id)
        {
            return _db.Categories.Find(id);
        }

        public IQueryable<CommentCategory> GetAllCommentCategories()
        {
            return _db.CommentCategories;
        }

        public CommentCategory GetCommentCategoryById(int id)
        {
            return _db.CommentCategories.Find(id);
        }

        public void Add(CommentCategory commentCategory)
        {
            _db.CommentCategories.Add(commentCategory);
        }

        public void Delete(CommentCategory commentCategory)
        {
            _db.CommentCategories.Remove(commentCategory);
        }



    }
}