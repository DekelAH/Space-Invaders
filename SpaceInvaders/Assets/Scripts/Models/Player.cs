using Assets.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Models
{
    public abstract class Player : BaseModel
    {
        #region Fields

        private new readonly Transform transform;

        #endregion

        #region Methods

        public override void Move(float horizontal)
        {
            var deltaX = horizontal * Speed;
            var newX = transform.position.x + deltaX;
            transform.position = new Vector2(newX, transform.position.y);
        }

        public override void Shoot()
        {
            throw new NotImplementedException();
        }


        #endregion
    }
}
