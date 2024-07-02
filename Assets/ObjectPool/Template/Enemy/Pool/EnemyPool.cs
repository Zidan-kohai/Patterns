using ObjectPool.Template.Enemy.Units;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace ObjectPool.Template.Enemy.Pool
{
    public class EnemyPool : MonoBehaviour
    {
        private List<Base.Enemy> enemiesPrefab;
        private Transform enemiesHandler;
        private ObjectPool.Base.ObjectPool<Base.Enemy> enemyPool;

        private void Start()
        {
            enemyPool = new ObjectPool.Base.ObjectPool<Base.Enemy>(enemiesPrefab, enemiesHandler, 5, true);


            Base.Enemy enemy_00 = enemyPool.GetFree(); //Return random enemy
            Base.Enemy enemy_01 = enemyPool.GetFree<MeleeEnemy>(); // Return meleeEnemy 
            Base.Enemy enemy_02 = enemyPool.GetFreeWithout<MeleeEnemy>(); // Return random enemy without meleeEnemy
        }

    }
}
