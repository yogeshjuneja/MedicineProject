using MedEntity.ContextModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedInterface
{
    public interface IMedRepo
    {
        public bool AddMedicine(Medicine Data);
        public dynamic ShowMedicineList();
        public Medicine GetMedicineDetails(int MedId);
    }
}
