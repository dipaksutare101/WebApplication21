using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Entity
{
    public class Invoice
    {
        public virtual double GetInvoiceDiscount(double amount)
        {
            return amount - 10;
        }
        public virtual int GetAmount()
        {
            return 10;
        }

    }

    public class FinalInvoice : Invoice
    {
        public override double GetInvoiceDiscount(double amount)
        {
            return 900;
        }

        sealed public override int GetAmount()
        {
            return base.GetAmount();
        }

    }
    public class ProposedInvoice : Invoice
    {
        public override double GetInvoiceDiscount(double amount)
        {
            return base.GetInvoiceDiscount(amount) - 40;
        }
    }
    public class RecurringInvoice : Invoice
    {
        public override double GetInvoiceDiscount(double amount)
        {
            return base.GetInvoiceDiscount(amount) - 30;
        }
    }

    
    public class tests : FinalInvoice
    {

    }
    public abstract class Fruit
    {
        public abstract string Getcolor();
        
    }

    public class apple :Fruit
    {
        public override string Getcolor()
        {
            return "red";
        }
    }

    public class Orange : Fruit
    {
        public override string Getcolor()
        {
            return "Orange";
        }
    }
}