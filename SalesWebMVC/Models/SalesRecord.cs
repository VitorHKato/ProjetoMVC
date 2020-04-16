using System;
using SalesWebMVC.Models.Enums;
namespace SalesWebMVC.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public double Amount { get; set; }

        public SaleStatus Status { get; set; }

        public Seller Seller { get; set; }

        public SalesRecord()
        {

        }

        public SalesRecord(int Id, DateTime Date, double Amount, SaleStatus Status, Seller Seller)
        {
            this.Id = Id;
            this.Date = Date;
            this.Amount = Amount;
            this.Status = Status;
            this.Seller = Seller;
        }
    }
}
