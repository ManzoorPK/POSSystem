
using POS_System.Model;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

public class CategoryHelper
{
    POS_SystemEntities _Entity = new POS_SystemEntities();
    public int SaveEditCategory(Category model)
    {
        try
        {
            var obj = _Entity.Categories.AsNoTracking().Where(x=> x.Category1.ToLower() == model.Category1.ToLower()).FirstOrDefault();
            
            if (obj != null) {
                return obj.CategoryId;
            }

            _Entity.Entry(model).State = (model.CategoryId == 0 ? EntityState.Added : EntityState.Modified);
            _Entity.SaveChanges();
            return model.CategoryId;
        }
        catch (Exception ex)
        {
            return 0;
        }
    }

    public string GetCategoryById(int Id)
    {
        var obj =  _Entity.Categories.Where(x=> x.CategoryId == Id).FirstOrDefault();
        if (obj != null)
            return obj.Category1;
        else
            return "";
    }
    public List<Category> GetAllCategories(bool ShowDefaultValue = false)
    {
        if (!ShowDefaultValue)
        return _Entity.Categories.ToList();
        else
        {
            var list = new List<Category>();
            list.Add(new Category
            {
                Category1 = "All",
                CategoryId = -1
            });

            foreach (var item in _Entity.Categories)
            {
                list.Add(item);
            }

            return list;
        }
    }
    
}

