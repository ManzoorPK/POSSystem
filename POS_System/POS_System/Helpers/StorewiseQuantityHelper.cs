
using POS_System.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

public class StorewiseQuantityHelper
{
    POS_SystemEntities _Entity = new POS_SystemEntities();
    public bool SaveEditStorewiseQty(StorewiseQuantity model)
    {
        try
        {
            _Entity.Entry(model).State = (model.StoreQuantityId == 0 ? EntityState.Added : EntityState.Modified);
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

    public List<StorewiseQuantityV> GetAllStoresQuantity(int Id)
    {
        List<StorewiseQuantityV> lst = new List<StorewiseQuantityV>();

        var obj = new StoreHelper().GetAllStores();
        if (obj.Count > 0)
        {
            foreach (var o in obj)
            {
                var record = _Entity.StorewiseQuantityVs.Where(x => x.ProductId == Id && o.StoreId == x.StoreId).FirstOrDefault();
                if (record != null)
                {
                    lst.Add(record);
                }
                else
                {
                    lst.Add(new StorewiseQuantityV
                    {
                         StoreId = o.StoreId,
                         ProductId = Id,
                         Store = new StoreHelper().GetStoreById(o.StoreId).Store1,
                         Quantity = 0
                    });
                }
            }
        }
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

