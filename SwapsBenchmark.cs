using System;
using System.Collections;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;

namespace bencmark
{
	[MemoryDiagnoser]

	public class SwapsBenchmark
	{
		[Benchmark]

		public void GenericsSwapBenchmarks()
		{
			double a = 1;
			double b = 5.3;
			SwapTestClass.GenericSwap(ref a, ref b);
		}

		[Benchmark]
		public void SwapBenchmark()
		{
			object p1 = 2;
			object p2 = 4;
			SwapTestClass.Swap(ref p1, ref p2);
		}
	}

}

