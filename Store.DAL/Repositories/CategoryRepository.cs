﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Store.DAL.Context;
using Store.DAL.Entities;
using Store.DAL.Interfaces;

namespace Store.DAL.Repositories
{
    public class CategoryRepository : Repository, IRepository<Category>
    {
        public CategoryRepository(StoreContext storeContext) : base(storeContext)
        {
        }

        public IEnumerable<Category> GetAll()
        {
            return db.Categories;
        }

        public Category Get(int id)
        {
            return db.Categories.Find(id);
        }

        public IEnumerable<Category> Find(Func<Category, bool> predicate)
        {
            return db.Categories.Where(predicate);
        }

        public void Add(Category entity)
        {
            db.Categories.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var category = db.Categories.Find(id);
            if (category != null)
            {
                db.Categories.Remove(category);
                db.SaveChanges();
            }
        }

        public void Edit(Category entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}