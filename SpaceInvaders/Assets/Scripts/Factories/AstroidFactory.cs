using Assets.Scripts.Models;
using UnityEngine;

namespace Assets.Scripts.Factories
{
    public class AstroidFactory : ObstacleFactoryBase
    {
        #region Fields

        [SerializeField] private Object _astroidPrefabRef;

        #endregion

        #region Methods

        public override void RandomAstroidSpawner()
        {
            var spawnPosition = new Vector2(Random.Range(-4.0f,7.0f), 7.0f);
            Instantiate(_astroidPrefabRef, spawnPosition, Quaternion.identity);
        }

        #endregion
    }
}
