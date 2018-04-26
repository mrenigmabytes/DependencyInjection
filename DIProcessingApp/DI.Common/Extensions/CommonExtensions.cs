using System;
using System.Collections.Generic;
using System.Linq;

namespace DI.Common.Extensions
{
    public static class CommonExtensions
    {
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> array) { return array == null || !array.Any(); }
    }
}
