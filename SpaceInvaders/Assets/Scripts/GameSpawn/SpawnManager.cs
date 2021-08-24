using Assets.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.GameSpawn
{
    public class SpawnManager : IUpdatable
    {
        #region Methods

        public void Update()
        {
            GamePlayElements.Instance.AstroidFactory.RandomAstroidSpawner();
        }

        #endregion
    }
}
