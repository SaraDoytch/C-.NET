using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Sale
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int RequiredAmount { get; set; }
        public double SalePrice { get; set; }
        public bool IsForClubMembers { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public override string ToString() => this.ToStringProperty();
        public Sale(int code, int id, int min, double price, bool club, DateTime start, DateTime end )
        {
            this.Id = code;
            this.ProductId = id;
            this.RequiredAmount = min;
            this.SalePrice = price;
            this.IsForClubMembers = club;
            this.StartDate = start;
            this.EndDate = end;
        }
        public Sale(int id, int min, double price, bool club, DateTime start, DateTime end)
        {
            //this.Id = code;
            this.ProductId = id;
            this.RequiredAmount = min;
            this.SalePrice = price;
            this.IsForClubMembers = club;
            this.StartDate = start;
            this.EndDate = end;
        }
        public Sale()
        {
            this.Id = 0;
            this.ProductId = 0;
            this.SalePrice = 0;
            this.RequiredAmount = 0;
            this.IsForClubMembers = false;
            this.StartDate = new DateTime();
            this.EndDate = EndDate;
        }
    }
}
