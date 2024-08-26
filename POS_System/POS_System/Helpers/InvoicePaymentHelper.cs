using POS_System.Model;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

public class InvoicePaymentHelper
{
    POS_SystemEntities _Entity = new POS_SystemEntities();
    public bool SaveEditInvoicePayment(InvoicePayment model)
    {
        try
        {
            _Entity.Entry(model).State = (model.InvoicePaymentId == 0 ? EntityState.Added : EntityState.Modified);
            _Entity.SaveChanges();
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }
    public List<InvoicePaymentV> GetInvoicePayment(int InvoiceId)
    {
        var lst = _Entity.InvoicePaymentVs.Where(x => x.InvoiceId == InvoiceId).ToList();
        return lst;
    }
}

