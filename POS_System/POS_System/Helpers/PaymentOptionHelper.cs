
using POS_System.Model;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

public class PaymentOptionHelper
{
    POS_SystemEntities _Entity = new POS_SystemEntities();
    public bool SaveEditPaymentOption(PaymentOption model)
    {
        try
        {
           
            _Entity.Entry(model).State = (model.PaymentOptionsId == 0 ? EntityState.Added : EntityState.Modified);
            _Entity.SaveChanges();
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public PaymentOption GetPaymentionOptionById(int Id)
    {
        var obj =  _Entity.PaymentOptions.Where(x=> x.PaymentOptionsId == Id).FirstOrDefault();
        return obj;
    }
    public List<PaymentOption> GetAllPaymentOptions()
    {
        return _Entity.PaymentOptions.ToList();  
    }
    public bool DeletePaymentOption(int Id)
    {
        try
        {
            var obj = _Entity.PaymentOptions.Where(x => x.PaymentOptionsId == Id).FirstOrDefault();
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


