﻿
using POS_System.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

public class InvoiceItemHelper
{
    POS_SystemEntities _Entity = new POS_SystemEntities();
    public InvoiceItem SaveEditInvoiceItem(InvoiceItem model)
    {
        try
        {
            _Entity.Entry(model).State = (model.InvoiceItemId == 0 ? EntityState.Added : EntityState.Modified);
            _Entity.SaveChanges();
            return model;
        }
        catch (Exception ex)
        {
            return null;
        }
    }

    public InvoiceItemsV GetInvoiceItemById(int Id)
    {
        var obj = _Entity.InvoiceItemsVs.Where(x => x.InvoiceItemId == Id).FirstOrDefault();
        return obj;
    }
    public InvoiceItem GetInvoiceSingleItemById(int Id)
    {
        var obj = _Entity.InvoiceItems.Where(x => x.InvoiceItemId == Id).FirstOrDefault();
        return obj;
    }
    public List<InvoiceItemsV> GetAllInvoicesItems(int InvoiceId)
    {
        var lst = _Entity.InvoiceItemsVs.Where(x => x.InvoiceId == InvoiceId).ToList();
        return lst;
    }

    public bool DeleteInvoiceItem(int Id, string invoiceType)
    {
        try
        {
            InvoiceItem obj = _Entity.InvoiceItems.Where(x => x.InvoiceItemId == Id).FirstOrDefault();
            new StorewiseQuantityHelper().ReturnQuantity(Convert.ToInt32(obj.ProductId), Convert.ToDecimal(obj.Qty), invoiceType);
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

