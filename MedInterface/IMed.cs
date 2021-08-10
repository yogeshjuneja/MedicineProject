using MedEntity.ContextModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedInterface
{
    public interface IMed
    {
        public string AddMedicine(Medicine Data);
        public dynamic ShowMedicineList();
        public Medicine GetMedicineDetails(int MedID);

    }
}
