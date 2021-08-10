using MedEntity.ContextModel;
using MedInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedService
{
    public class Med : IMed
    {
        private readonly IMedRepo _medicinerepo = null;
        public Med(IMedRepo _repo)
        {
            _medicinerepo = _repo;
        }
        string IMed.AddMedicine(Medicine Data)
        {
            if ((DateTime.Now - Data.ExpiryDate.Value).TotalDays < 15)
                return "Expiry is less than 15 days";
           bool success=  _medicinerepo.AddMedicine(Data);
            if (success)
                return "OK";
            else
                return "Failed";
        }

        Medicine IMed.GetMedicineDetails(int MedID)
        {
           return _medicinerepo.GetMedicineDetails(MedID);
        }

        dynamic IMed.ShowMedicineList()
        {
            return _medicinerepo.ShowMedicineList();
        }
    }
}
