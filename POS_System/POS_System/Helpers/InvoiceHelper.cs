
using POS_System.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

public class InvoiceHelper
{
    POS_SystemEntities _Entity = new POS_SystemEntities();
    public Invoice SaveEditInvoice(Invoice model)
    {
        try
        {

            _Entity.Entry(model).State = (model.InvoiceId == 0 ? EntityState.Added : EntityState.Modified);
            _Entity.SaveChanges();
            return model;
        }
        catch (Exception ex)
        {
            return null;
        }
    }

    public Invoice GetInvoiceById(int Id)
    {
        Invoice obj = _Entity.Invoices.Where(x => x.InvoiceId == Id).FirstOrDefault();
        return obj;
    }

    public List<InvoiceV> GetAllInvoices()
    {
        var lst = _Entity.InvoiceVs.Where(x=>x.InvoiceType == "Sales Invoice").ToList();
        return lst;
    }
    public List<InvoiceV> GetAllSalesReturnInvoices()
    {
        var lst = _Entity.InvoiceVs.Where(x => x.InvoiceType == "Sales Return Invoice").ToList();
<<<<<<< HEAD
        return lst;
    }

    public List<InvoiceV> GetAllSalesReturnPurchaseInvoices()
    {
        var lst = _Entity.InvoiceVs.Where(x => x.InvoiceType == "Purchase Return Invoice").ToList();
        return lst;
    }
    public List<InvoiceV> GetAllPurchaseInvoices()
    {
        var lst = _Entity.InvoiceVs.Where(x => x.InvoiceType == "Purchase Order").ToList();
=======
>>>>>>> 098309e356e61a35e52288eb7f7af42ead4f8c0e
        return lst;
    }
    public bool DeleteInvoice(int Id)
    {
        try
        {
            Invoice obj = _Entity.Invoices.Where(x => x.InvoiceId == Id).FirstOrDefault();
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

