using Assets.Models;
using Assets.Scripts.Factories;
using Assets.Scripts.Models;
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
        [SerializeField] private Astroid _astroid;

        #endregion

        #region Properties

        public Player Player => _player;
        public AstroidFactory AstroidFactory => _astroidFactory;
        public Astroid Astroid => _astroid;

        #endregion

        #region Methods

        protected override GamePlayElements GetInstance()
        {
            return this;
        }

        #endregion
    }
}
