using UnityEngine;

namespace FactoryMethod.Base
{
    public abstract class Creater : MonoBehaviour 
    {
        public abstract Unit Create();
    }
}
