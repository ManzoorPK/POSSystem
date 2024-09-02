
using POS_System.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

public class ReceiptHelper
{
    POS_SystemEntities _Entity = new POS_SystemEntities();
    public bool SaveEditReceipt(Receipt model)
    {
        try
        {
            _Entity.Entry(model).State = (model.ReceiptId == 0 ? EntityState.Added : EntityState.Modified);
            _Entity.SaveChanges();
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }

   
    public Receipt GetReceiptById(int Id)
    {
        Receipt obj = _Entity.Receipts.Where(x => x.ReceiptId == Id).FirstOrDefault();
        return obj;
    }

    public List<ReceiptV> GetAllReceipts()
    {
        var lst = _Entity.ReceiptVs.ToList();
        return lst;
    }

    public bool DeleteReceipts(int Id)
    {
        try
        {
            Receipt obj = _Entity.Receipts.Where(x => x.ReceiptId == Id).FirstOrDefault();
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

