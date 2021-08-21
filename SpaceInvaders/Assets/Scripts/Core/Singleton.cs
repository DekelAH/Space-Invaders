using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets
{
    public abstract class Singleton<T> : MonoBehaviour
    {
        #region Fields

        private static T _instance;

        #endregion

        #region Methods

        private void Awake()
        {
            _instance = GetInstance();
        }

        protected abstract T GetInstance();

        #endregion

        #region Properties

        public T Instance
        {
            get
            {
                if (Instance == null)
                {
                    throw new Exception("Have no instance yet!");
                }

                return _instance;
            }
        }

        #endregion

    }
}
