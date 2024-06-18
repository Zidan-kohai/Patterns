using FactoryMethod.Base;
using UnityEngine;

namespace FactoryMethod.Template.Archer
{
    public class ArcherCreater : Creater
    {
        public override Unit Create()
        {
            Archer archerPrefab = Resources.Load<Archer>("ArcherPrefab");

            return Object.Instantiate(archerPrefab);
        }
    }
}