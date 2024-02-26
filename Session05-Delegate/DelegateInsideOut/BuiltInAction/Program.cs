namespace BuiltInAction
{
	//delegate void ActionDelegate(Action action);
	internal class Program
	{
		static void Main(string[] args)
		{
			//truyền thống delegate
			var printMsg = () => { Console.WriteLine("how's your life?"); };
			//printMsg.Invoke();

			//ko thèm xài delegate tự trồng, xài đồ mua sẵn, xài đồ mua sẵn của 
			Action showMsg = () => { Console.WriteLine("This is from Prebuilt Action Delegate."); };
			showMsg();
		}
	}
}
