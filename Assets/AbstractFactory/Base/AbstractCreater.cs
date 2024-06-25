namespace AbstractFactory.Base
{
    public abstract class AbstractCreater
    {
        public abstract TFactory CreateFactory<TFactory>() where TFactory : Factory;
    }
}
