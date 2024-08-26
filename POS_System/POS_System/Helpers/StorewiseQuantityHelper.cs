
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

    public List<StorewiseQuantity> GetProductQuantities(int ProductId)
    {
        return _Entity.StorewiseQuantities.Where(x=> x.InventoryId == ProductId).ToList();  
    }

    public void ManageStoreQuantity(int ProductId, decimal quantity)    
    {
        decimal Qty = quantity;
        var obj = new StorewiseQuantityHelper().GetProductQuantities(ProductId);
        decimal _NetQty = 0;
        decimal _NewQty = 0;
        foreach (var item in obj)
        {

            if (_NetQty > 0)
                _NewQty = _NetQty;
            else
                _NewQty = Qty;

            if (item.Balance >= _NewQty)
            {
                item.SoldOut = _NewQty;
                _Entity.Entry(item).State = (item.StoreQuantityId == 0 ? EntityState.Added : EntityState.Modified);
                _Entity.SaveChanges();
                break;
            }
            else
            {
                if (item.Balance > 0)
                {
                    _NetQty = _NewQty - Convert.ToDecimal(item.Balance);
                    item.SoldOut = item.Balance;
                    _Entity.Entry(item).State = (item.StoreQuantityId == 0 ? EntityState.Added : EntityState.Modified);
                    _Entity.SaveChanges();
                }
            }
        }
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

