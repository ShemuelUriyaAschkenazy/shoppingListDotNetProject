﻿using BE;
using DAL;
using System;
using System.Reflection;

namespace BLL
{
    public class BLAddingVal
    {
        private DbAdapter dbAdapter;

        public BLAddingVal()
        {
            dbAdapter = new DbAdapter();
        }

        public void Save(Category category)
        {
            
            dbAdapter.Save(category);
        }

        public Category Add(Category obj)
        {
            obj.CategoryId = dbAdapter.GetMaxCategoryId() + 1;
            return dbAdapter.Add(obj);
        }

        public Product Add(Product obj)
        {
            obj.ProductId = dbAdapter.GetMaxProductId() + 1;
            return dbAdapter.Add(obj);
        }

        public User Add(User obj)
        {
            obj.UserId = dbAdapter.GetMaxUserId() + 1;
            return dbAdapter.Add(obj);
        }

        public Store Add(Store obj)
        {
            obj.StoreId = dbAdapter.GetMaxStoreId() + 1;
            return dbAdapter.Add(obj);
        }

        public Buying Add(Buying obj)
        {
            obj.BuyingId = dbAdapter.GetMaxBuyingId() + 1;
            return dbAdapter.Add(obj);
        }
    }
}
