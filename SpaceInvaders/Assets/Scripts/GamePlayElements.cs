using Assets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public class GamePlayElements : Singleton<GamePlayElements>
    {
        #region Editor Fields

        [SerializeField] public Player _player;

        #endregion

        #region Properties

        public Player Player => _player;

        #endregion

        #region Methods

        protected override GamePlayElements GetInstance()
        {
            return this;
        }

        #endregion
    }
}
