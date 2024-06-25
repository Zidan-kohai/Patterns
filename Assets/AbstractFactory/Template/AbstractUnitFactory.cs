using AbstractFactory.Base;
using AbstractFactory.Template.Green;
using AbstractFactory.Template.Red;
using System;
using UnityEngine;

namespace AbstractFactory.Template
{
    public class AbstractUnitFactory : AbstractCreater
    {
        public const string GreenUnitsFactoryPath = "";
        public const string RedUnitsFactoryPath = "";


        public override TFactory CreateFactory<TFactory>()
        {
            if(typeof(TFactory) == typeof(GreenUnitFactory))
            {
                GreenUnitFactory greenUnitCreaterPrefab = Resources.Load<GreenUnitFactory>(GreenUnitsFactoryPath);
                return UnityEngine.Object.Instantiate(greenUnitCreaterPrefab) as TFactory;
            }
            else if(typeof(TFactory) == typeof(RedUnitFactory))
            {
                RedUnitFactory redUnitCreaterPrefab = Resources.Load<RedUnitFactory>(GreenUnitsFactoryPath);
                return UnityEngine.Object.Instantiate(redUnitCreaterPrefab) as TFactory;
            }

            throw new ArgumentException($"AbstractUnitFactory don`t {typeof(TFactory)}");
        }
    }
}
