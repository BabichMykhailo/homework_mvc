﻿using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public interface ICategoryRepository
    {
        void Create(Category model);

        void DeleteById(int id);

        Category GetById(int id);
        void Edit(Category editedCategory);

        IEnumerable<Category> GetMyCategories();
    }

    public class CategoryRepository : ICategoryRepository
    {
        private readonly WebApplication_A_LEVELContext _ctx;

        public CategoryRepository()
        {
            _ctx = new WebApplication_A_LEVELContext();
        }

        public void Create(Category model)
        {
            _ctx.Categories.Add(model);

            _ctx.SaveChanges();
        }

        public void DeleteById(int id)
        {
            var entity = _ctx.Categories.FirstOrDefault(x => x.Id == id);
            _ctx.Categories.Remove(entity);

            _ctx.SaveChanges();
        }

        public Category GetById(int id)
        {
            return _ctx.Categories.FirstOrDefault(x => x.Id == id);
        }

        public void Edit(Category editedCategory)
        {
            var category = GetById(editedCategory.Id);

            category.Title = editedCategory.Title;
            category.UpdatedDate = DateTime.Now;

            _ctx.SaveChanges();
        }

        public IEnumerable<Category> GetMyCategories()
        {
            return _ctx.Categories.ToList();
        }
    }
}
