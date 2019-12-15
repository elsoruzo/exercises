namespace Factory.Model
{
    internal class ConcreteCreatorDefoult : FactoryCreator
    {
        public override IProduct FactoryMethod()
        {
            throw new System.NotImplementedException();
        }
    }
}