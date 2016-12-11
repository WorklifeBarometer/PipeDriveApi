using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeDriveApi
{
    public class PaginatedPipeDriveResponse<T> : PipeDriveResponse<List<T>>
    {
        public AdditionalDataInfo AdditionalData { get; set; }
        public class AdditionalDataInfo
        {
            public PaginationInfo Pagination { get; set; }
        }
        
    }
}
