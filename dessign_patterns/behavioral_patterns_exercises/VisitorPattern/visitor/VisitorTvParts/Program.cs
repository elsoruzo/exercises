namespace VisitorTvParts
{
	using VisitorTvParts.Models;
	class Program
    {
        static void Main(string[] args)
        {
			PartsOrder order = new PartsOrder();
			order.AddPart(new Wheel());
			order.AddPart(new Fender());
			order.AddPart(new Oil());

			order.Accept(new AtvPartsShippingVisitor());
			order.Accept(new AtvPartsDisplayVisitor());
		}
    }
}
