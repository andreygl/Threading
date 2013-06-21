namespace ConsoleApplication1
{
	using ConsoleApplication1.ThreadPools;

	class Program
	{
		static void Main(string[] args)
		{
			TplLibrary.SimpleCallThread();

			// TplLibrary.SimpleGenericCallThread();

			ThreadPoolBefore4_0.QueueUserWorkItemCall();
		}
	}
}
