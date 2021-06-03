using System;
using ProjAspNet.Models.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjAspNet.Models;

namespace ProjAspNet.Data
{
    public class SeedingService
    {
        private ProjAspNetContext _context;
        public SeedingService(ProjAspNetContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Departament.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())            
                return;

            Departament d1 = new Departament(1, "Computers");
            Departament d2 = new Departament(2, "Electronics");
            Departament d3 = new Departament(3, "Fashion");
            Departament d4 = new Departament(4, "Books");

            Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1998,4,21), 1000.0, d1);
            Seller s2 = new Seller(2, "Bob Green", "Bob2@gmail.com", new DateTime(1979, 3, 21), 3500, d2);
            Seller s3 = new Seller(3, "Bob Grey", "Bob3@gmail.com", new DateTime(1980, 4, 1), 2000, d1);
            Seller s4 = new Seller(4, "Bob Red ", "Bob4@gmail.com", new DateTime(2000, 7, 3), 1200, d4);
            Seller s5 = new Seller(5, "Bob Blue", "Bob5@gmail.com", new DateTime(1997, 9, 8), 3200, d3);
            Seller s6 = new Seller(6, "Bob Pink", "Bob6@gmail.com", new DateTime(1993, 10, 10), 1980, d2);

            SalesRecord sr1 = new SalesRecord(1, new DateTime(2018, 09, 25), 11000, SaleStatus.Billed, s1);
            SalesRecord sr2 = new SalesRecord(2, new DateTime(2015, 10, 18), 11000, SaleStatus.Billed, s2);
            SalesRecord sr3 = new SalesRecord(3, new DateTime(2016, 01, 03), 11000, SaleStatus.Billed, s2);

            _context.Departament.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SalesRecord.AddRange(sr1, sr2, sr3);

            _context.SaveChanges();

        }
    }
}
