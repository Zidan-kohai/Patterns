using AbstractFactory.Base;
using AbstractFactory.Template.Base;
using UnityEngine;

namespace AbstractFactory.Template.Red
{
    public class RedUnitFactory : Factory
    {
        public override Archer CreateArcher()
        {
            Archer archerPrefab = Resources.Load<Archer>("redArcherPrefab");

            return Object.Instantiate(archerPrefab);
        }

        public override SwordMan CreateSwordMan()
        {
            SwordMan swordManPrefab = Resources.Load<SwordMan>("redSwordManPrefab");

            return Object.Instantiate(swordManPrefab);
        }
    }
}
