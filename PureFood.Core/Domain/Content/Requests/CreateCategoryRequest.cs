using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureFood.Core.Domain.Content.Requests
{
    public class CreateCategoryRequest
    {
      //  public Guid CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string? Description { get; set; }
    }
}
