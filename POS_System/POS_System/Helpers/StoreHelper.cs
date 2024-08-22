
using POS_System.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

public class StoreHelper
{
    POS_SystemEntities _Entity = new POS_SystemEntities();
    public bool SaveEditStore(Store model)
    {
        try
        {
            _Entity.Entry(model).State = (model.StoreId == 0 ? EntityState.Added : EntityState.Modified);
            _Entity.SaveChanges();
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public Store GetStoreById(int Id)
    {
        Store obj = _Entity.Stores.Where(x => x.StoreId == Id).FirstOrDefault();
        return obj;
    }

    public List<Store> GetAllStores()
    {
        var lst = _Entity.Stores.ToList();
        return lst;
    }

    public bool DeleteStore(int Id)
    {
        try
        {
            Store obj = _Entity.Stores.Where(x => x.StoreId == Id).FirstOrDefault();
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

