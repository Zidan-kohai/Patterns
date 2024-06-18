using AbstractFactory.Template.Base;

namespace AbstractFactory.Base
{
    public abstract class Creater 
    {
        public abstract SwordMan CreateSwordMan();

        public abstract Archer CreateArcher();
    }
}
