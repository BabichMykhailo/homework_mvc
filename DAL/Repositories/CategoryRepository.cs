﻿using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class CategoryRepository
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

        public IEnumerable<Category> GetMyCategories()
        {
            return _ctx.Categories.ToList();
        }
    }
}
