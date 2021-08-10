
using MedEntity.ContextModel;
using MedInterface;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedRepository
{
    public class MedRepo : IMedRepo
    {
        private readonly DBContext _context = null;
        private readonly IConfiguration _configuration = null;
        public MedRepo(DBContext context, IConfiguration configuration)
        {
            _configuration = configuration;
            _context = context;
        }
        bool IMedRepo.AddMedicine(Medicine Data)
        {
            _context.Medicine.Add(Data);
            int result = _context.SaveChanges();
            return result > 0;
        }

        Medicine IMedRepo.GetMedicineDetails(int Medid)
        {
            throw new NotImplementedException();
        }

        dynamic IMedRepo.ShowMedicineList()
        {
             
            return _context.Medicine.Select(x =>
            new
            {
                MedicineName = x.MedName,
                MedicineId = x.MedcineId,
                Price = x.Price,
                Quantity = x.Quantity,
                expirydate = x.ExpiryDate,
                Color=x.Quantity<10?"Yellow": (DateTime.Now - x.ExpiryDate.Value).TotalDays > 15?"Red":"Default",
            }
            ).ToList();
        }
    }
}
