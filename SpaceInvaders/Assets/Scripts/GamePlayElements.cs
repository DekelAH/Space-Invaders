using Assets.Models;
using Assets.Scripts.Factories;
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

        [SerializeField] private Player _player;
        [SerializeField] private AstroidFactory _astroidFactory;

        #endregion

        #region Properties

        public Player Player => _player;
        public AstroidFactory AstroidFactory => _astroidFactory;

        #endregion

        #region Methods

        protected override GamePlayElements GetInstance()
        {
            return this;
        }

        #endregion
    }
}
