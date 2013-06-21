namespace ConsoleApplication1.ThreadPools
{
	using System;
	using System.Threading;

	public class ThreadPoolBefore4_0
	{
		static void Go(object data)
		{
			Console.WriteLine("Hello from the thread pool! " + data);
		}

		public static void QueueUserWorkItemCall()
		{
			ThreadPool.QueueUserWorkItem(Go);
			ThreadPool.QueueUserWorkItem(Go, 123);
			Console.ReadLine();

			// no easy mechanism to return values from a thread after it has finished executing
		}

		/// <summary>
		/// 1. Allow any number of typed arguments
		/// 2. Unhandled exception rethrown on original thread. Don't need explicit handling.
		/// </summary>
		public static void AsynchronousDelegatesCall()
		{
			
		}
	}
}