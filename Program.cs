using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int beforeGen0 = GC.CollectionCount(0);
            long beforeTotalMemory = GC.GetTotalMemory(forceFullCollection: true);

            var list = SingleLinkedList<object>.Empty;

            for (int i = 0; i < 5000000; i++)
            {
                list = list.Add(null);
            }

            int collections = GC.CollectionCount(0) - beforeGen0;
            long bytesAllocated = GC.GetTotalMemory(forceFullCollection: true) - beforeTotalMemory;

            GC.KeepAlive(list);

            Console.WriteLine($"Gen0 collections: {collections}. Bytes allocated: {bytesAllocated}.");
        }
    }
}
