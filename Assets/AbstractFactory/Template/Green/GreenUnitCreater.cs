using AbstractFactory.Base;
using AbstractFactory.Template.Base;
using UnityEngine;

namespace AbstractFactory.Template.Green
{
    public class GreenUnitCreater : Creater
    {
        public override Archer CreateArcher()
        {
            Archer archerPrefab = Resources.Load<Archer>("greenArcherPrefab");

            return Object.Instantiate(archerPrefab);
        }

        public override SwordMan CreateSwordMan()
        {
            SwordMan swordManPrefab = Resources.Load<SwordMan>("greenSwordManPrefab");

            return Object.Instantiate(swordManPrefab);
        }
    }
}
