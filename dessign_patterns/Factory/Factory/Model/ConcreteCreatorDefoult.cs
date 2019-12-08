namespace Factory.Model
{
    internal class ConcreteCreatorDefoult : Creator
    {
        public override IProduct FactoryMethod()
        {
            throw new System.NotImplementedException();
        }
    }
}