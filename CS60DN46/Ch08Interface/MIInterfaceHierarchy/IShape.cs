namespace MIInterfaceHierarchy
{
	interface IShape : IDrawable, IPrintable
	{
		int GetNumberOfSides();
	}
}
