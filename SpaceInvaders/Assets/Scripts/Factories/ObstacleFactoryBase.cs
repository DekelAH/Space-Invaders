using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Factories
{
    public abstract class ObstacleFactoryBase : MonoBehaviour
    {
        #region Methods

        public abstract void RandomAstroidSpawner();

        #endregion
    }
}
