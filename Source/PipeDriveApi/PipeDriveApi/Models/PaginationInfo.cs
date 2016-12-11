using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeDriveApi
{
    public class PaginationInfo
    {
        public int Start { get; set; }
        public int Limit { get; set; }
        public bool MoreItemsInCollection { get; set; }
        public int NextStart { get; set; }
    }
}
