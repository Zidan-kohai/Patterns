using AbstractFactory.Template.Base;
using UnityEngine;

namespace AbstractFactory.Base
{
    public abstract class Factory : MonoBehaviour
    {
        public abstract SwordMan CreateSwordMan();

        public abstract Archer CreateArcher();
    }
}
