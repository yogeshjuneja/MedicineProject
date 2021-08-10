using System;
using System.Collections.Generic;

namespace MedEntity.ContextModel
{
    public partial class Medicine
    {
        public int MedcineId { get; set; }
        public string MedName { get; set; }
        public decimal? Price { get; set; }
        public int? Quantity { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string Notes { get; set; }
    }
}
