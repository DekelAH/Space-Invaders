using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Models
{
    public abstract class BaseModel : MonoBehaviour
    {
        #region Properties

        [SerializeField]
        public abstract int Health { get; set; }

        [SerializeField]
        public abstract float Speed { get; set; }


        #endregion

        #region Methods

        public abstract void Move(float horizontal);


        public abstract void Shoot();


        #endregion
    }
}
