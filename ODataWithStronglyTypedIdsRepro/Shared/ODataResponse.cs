using System.Collections.Generic;

namespace ODataWithStronglyTypedIdsRepro.Shared
{
    public class ODataResponse<T>
    {
        public string Context { get; set; }

        public IEnumerable<T> Value { get; set; }
    }
}
