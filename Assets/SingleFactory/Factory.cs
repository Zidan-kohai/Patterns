using SingleFactory.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace SingleFactory
{
    public class Factory
    {
        private Dictionary<UnitType, UnitConfig> unitConfigs = new Dictionary<UnitType, UnitConfig>();

        public Factory() 
        {
            unitConfigs = Resources.LoadAll<UnitConfig>("Unit").ToDictionary(item => item.Type);
        }

        public Unit CreateUnit(UnitType type)
        {
            if (unitConfigs.ContainsKey(type))
            {
                Unit prefab = unitConfigs[type].UnitPrefab;

                Unit unit = UnityEngine.Object.Instantiate(prefab);

                unit.Constructoor(1,2,3);

                return unit;
            }

            throw new ArgumentException($"Single Factory doesn`t contain unit with {type} type");
        }
    }
}
