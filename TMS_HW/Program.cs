using System.Reflection;

namespace TMS_HW
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Assembly myLibAssembly = Assembly.LoadFrom("../../../../HW1Library/bin/Debug/net8.0/HW1Library.dll");

			Type myLibType = myLibAssembly.GetType("HW1Library.HelloClass");

			object myLibInstance = Activator.CreateInstance(myLibType);

			MethodInfo helloMethod = myLibType.GetMethod("Hello");

			Console.WriteLine(helloMethod.Invoke(myLibInstance, null));
		}
	}
}
