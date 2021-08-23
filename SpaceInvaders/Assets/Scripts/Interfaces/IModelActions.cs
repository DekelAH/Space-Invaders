﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Interfaces
{
    interface IModelActions
    {
        #region Methods

        void Move(float horizontal);

        void Shoot();

        #endregion
    }
}