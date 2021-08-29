using Assets.Scripts.Interfaces;
using Assets.Scripts.Models;
using Assets.Services;
using UnityEngine;

namespace Assets.Scripts.Factories
{
    public class AstroidFactory : ObstacleFactoryBase
    {
        #region Editor

        [SerializeField] private Object _astroidPrefabRef;

        #endregion


        #region Methods

        public override GameObject Create(Vector2 startPosition, Quaternion rotation)
        {
            var _astroid = (GameObject)Instantiate(_astroidPrefabRef, startPosition, rotation.normalized);

            return _astroid;
        }
        #endregion
    }
}
