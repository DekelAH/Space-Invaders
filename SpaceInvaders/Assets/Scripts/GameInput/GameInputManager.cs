using Assets.Interfaces;
using Assets.Scripts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.GameInput
{
    public class GameInputManager : IUpdatable
    {

        #region

        public void Update()
        {
            GamePlayElements.Instance.Player.Move(Input.GetAxis("Horizontal"));
        }

        #endregion
    }
}
