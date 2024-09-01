
using POS_System.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

public class WarehouseHelper
{
    POS_SystemEntities _Entity = new POS_SystemEntities();
    public bool SaveEditHelper(Warehouse model)
    {
        try
        {
            _Entity.Entry(model).State = (model.WarehouseId == 0 ? EntityState.Added : EntityState.Modified);
            _Entity.SaveChanges();
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }
    public bool SaveEditQuantity(WarehouseWiseQuantity model)
    {
        try
        {
            _Entity.Entry(model).State = (model.WarehouseQuantityId == 0 ? EntityState.Added : EntityState.Modified);
            _Entity.SaveChanges();
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public bool DeleteWarehouseQuantity(int Id)
    {
        try
        {
            WarehouseWiseQuantity obj = _Entity.WarehouseWiseQuantities.Where(x => x.InvoiceItemId == Id).FirstOrDefault();
            _Entity.Entry(obj).State = EntityState.Deleted;
            _Entity.SaveChanges();
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }
    public Warehouse GetWarehouseById(int Id)
    {
        Warehouse obj = _Entity.Warehouses.Where(x => x.WarehouseId == Id).FirstOrDefault();
        return obj;
    }

    public List<Warehouse> GetAllWarehoues()
    {
        var lst = _Entity.Warehouses.ToList();
        return lst;
    }

    public bool DeleteWarehouse(int Id)
    {
        try
        {
            Warehouse obj = _Entity.Warehouses.Where(x => x.WarehouseId == Id).FirstOrDefault();
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

