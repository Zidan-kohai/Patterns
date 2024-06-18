using FactoryMethod.Base;
using UnityEngine;

namespace FactoryMethod.Template.SwordMan
{
    public class SwordManCreater : Creater
    {
        public override Unit Create()
        {
            SwordMan swordManPrefab = Resources.Load<SwordMan>("SwordManPrefab");

            return Object.Instantiate(swordManPrefab);
        }
    }
}
