using System;
using System.Collections;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
namespace bencmark
{
    namespace Benchmark
    {
        public class ListsBenchmark
        {
            [Benchmark]
            public void ArrayListsBenchmark()
            {
                ArrayList arrayList = new ArrayList();

                for (int i = 0; i < 1000; i++)
                {
                    arrayList.Add(i);

                }
            }
            [Benchmark]
            public void ListBenchmark()
            {
                List<int> list = new List<int>();

                for (int i = 0; i < 1000; i++)
                {
                    list.Add(i);
                }
            }

        }

    }
}

