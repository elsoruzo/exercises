namespace FactoryModel
{
    class ConcreteCreator2 : FactoryCreator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}
