using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Logical_programming
{
    public class Stop_watch
    {
        public void StopWatch()
        {
			// Create new stopwatch
			Stopwatch stopwatch = new Stopwatch();

			// Begin timing
			stopwatch.Start();

			// Do something
			for (int i = 0; i < 100; i++)
			{
				Thread.Sleep(1);
			}

			// Stop timing
			stopwatch.Stop();

			// Write result
			Console.WriteLine("Time elapsed: {0}",
				stopwatch.Elapsed);
		}
    }
}
