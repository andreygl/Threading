namespace ConsoleApplication1.ThreadPools
{
	using System;
	using System.Net;
	using System.Threading.Tasks;

	public static class TplLibrary
	{
		static void Go()
		{
			Console.WriteLine("This is TPL library thread pool");
		}

		public static void SimpleCallThread()
		{
			Task.Factory.StartNew(Go).Wait();
		}

		static string DownloadString(string uri)
		{
			using (var wc = new WebClient()) return wc.DownloadString(uri);
		}

		public static void SimpleGenericCallThread()
		{
			var task = Task.Factory.StartNew<string>(() => DownloadString("http://www.linqpad.net"));

			var a = 10 + 20;

			// current thread will now  block (wait) until the task finishes
			string result = task.Result;
			Console.WriteLine(result);
		}
	}
}