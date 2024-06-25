using AbstractFactory.Base;
using AbstractFactory.Template.Green;
using AbstractFactory.Template.Red;
using System;
using System.Collections.Generic;
using UnityEngine;


namespace AbstractFactory.Template
{
    public class AbstractUnitFactory : AbstractCreater
    {
        private Dictionary<Type, string> prefabPathf = new Dictionary<Type, string>()
        {
            {typeof(GreenUnitFactory), "GreenUnitFactory"},
            {typeof(RedUnitFactory), "RedUnitFactory"},
        };

        public override TFactory CreateFactory<TFactory>()
        {

            if(prefabPathf.TryGetValue(typeof(TFactory), out string pathf))
            {
                return Resources.Load<TFactory>(pathf);
            }

            throw new ArgumentException($"AbstractFactory don`t have {typeof(TFactory)}");
        }
    }
}
