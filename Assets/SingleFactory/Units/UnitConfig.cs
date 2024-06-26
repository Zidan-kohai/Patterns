using UnityEngine;

namespace SingleFactory.Units
{
    public class UnitConfig : ScriptableObject
    {
        public UnitType Type { get; private set; }

        public Unit UnitPrefab { get; private set; }
    }
}
