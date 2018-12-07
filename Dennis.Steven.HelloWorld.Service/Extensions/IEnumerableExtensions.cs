using System;
using System.Collections.Generic;

namespace Dennis.Steven.HelloWorld.Service.Extensions
{
    public static class IEnumerableExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> instances, Action<T> function)
        {
            foreach (var i in instances)
                function(i);
        }
    }
}
