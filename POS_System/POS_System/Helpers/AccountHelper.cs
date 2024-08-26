
using POS_System.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

public class AccountHelper
{
    POS_SystemEntities _Entity = new POS_SystemEntities();
    public Account SaveEditAccount(Account model)
    {
        try
        {
            _Entity.Entry(model).State = (model.AccountId == 0 ? EntityState.Added : EntityState.Modified);
            _Entity.SaveChanges();
            return model;
        }
        catch (Exception ex)
        {
            return null;
        }
    }

    public Account GetAccountById(int Id)
    {
        Account obj = _Entity.Accounts.Where(x => x.AccountId == Id).FirstOrDefault();
        return obj;
    }

    public List<Account> GetAllAccounts()
    {
        var lst = _Entity.Accounts.ToList();
        return lst;
    }

    public bool DeleteAccount(int Id)
    {
        try
        {
            Account obj = _Entity.Accounts.Where(x => x.AccountId == Id).FirstOrDefault();
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

