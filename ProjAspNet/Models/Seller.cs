using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjAspNet.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public DateTime BirhDate { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament{ get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {
        }

        public Seller(int id, string name, string mail, DateTime birhDate, double baseSalary, Departament departament)
        {
            Id = id;
            Name = name;
            Mail = mail;
            BirhDate = birhDate;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }

        public void RemoveSalves(SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }

    }
}
