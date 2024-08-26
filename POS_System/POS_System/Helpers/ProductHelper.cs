using POS_System.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

public class ProductHelper
{
    POS_SystemEntities _Entity = new POS_SystemEntities();
    public Product SaveEditProduct(Product model)
    {
        try
        {
            _Entity.Entry(model).State = (model.ProductId == 0 ? EntityState.Added : EntityState.Modified);
            _Entity.SaveChanges();
            return model;
        }
        catch (Exception ex)
        {
            return null;
        }
    }

    public Product GetProductById(int Id)
    {
        Product obj = _Entity.Products.Where(x => x.ProductId == Id).FirstOrDefault();
        return obj;
    }

    public List<Product> GetAllProducts()
    {
        var lst = _Entity.Products.ToList();
        return lst;
    }

    public bool DeleteProduct(int Id)
    {
        try
        {
            Product obj = _Entity.Products.Where(x => x.ProductId == Id).FirstOrDefault();
            _Entity.Entry(obj).State = EntityState.Deleted;
            _Entity.SaveChanges();
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }
}

