using UnityEngine;

namespace Assets.Scripts.Models
{
    public class Astroid : MonoBehaviour
    {
        #region Fields

        [SerializeField] private float _speed = 0.5f;
        [SerializeField] private int _health = 10;

        #endregion

        #region Methods

        public void Move()
        {

        }

        #endregion
    }
}
