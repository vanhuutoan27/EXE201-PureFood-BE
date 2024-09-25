using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureFood.Core.Models.content.Responses
{
    public class SupplierReponse
    {
        public Guid SupplierId { get; set; }
        public string SuplierName { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

    }
}
