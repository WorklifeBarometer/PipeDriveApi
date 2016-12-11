using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeDriveApi
{
    public class ListResult<T> : IReadOnlyList<T>
    {
        private IReadOnlyList<T> _List;
        internal ListResult(IReadOnlyList<T> list, PaginationInfo paginationInfo)
        {
            _List = list;
            Pagination = paginationInfo;
        }
        public PaginationInfo Pagination { get; private set; }
        public IEnumerator<T> GetEnumerator() => _List.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => _List.GetEnumerator();
        public int Count => _List.Count;
        public T this[int index] => _List[index];
    }
}
