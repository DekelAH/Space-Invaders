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
        #region Fields

        readonly GamePlayElements _gpe;

        #endregion

        #region

        public void Update()
        {
            var moveHorizontal = Input.GetAxis("Horizontal") * Time.deltaTime;
            _gpe.Instance.Player.Move(moveHorizontal);
        }

        #endregion
    }
}
