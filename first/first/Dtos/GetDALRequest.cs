using System;
using System.Collections.Generic;
using System.Text;

namespace first.Dtos
{
    public class GetDALRequest
    {
        public Guid Id { get; set; }
        public DALModel DAL { get; set; }
    }
}
