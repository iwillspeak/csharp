using System;

public class Application
{
	public void Run(string[] argv)
	{
		String world = "world";
		Console.WriteLine("Hello {0}", world);

		foreach (string arg in argv)
		{
			Console.WriteLine(arg);
		}
	}
}

public class Foo
{
  public static void Main(string[] argv)
  {
	Application app = new Application();
	app.Run(argv);
  }
}