using Assets.Scripts.Interfaces;
using UnityEngine;

namespace Assets.Scripts.Models
{
    public class Astroid : MonoBehaviour
    {
        #region Fields

        [SerializeField] private float _speed = 100f;
        [SerializeField] private int _health = 10;
        [SerializeField] Rigidbody2D rb;

        #endregion

        #region Methods

        private void Update()
        {
            Move();
        }

        public void Move()
        {

            var yAxis = _speed * (-1) * Time.deltaTime;
            transform.Translate(0, yAxis, 0);
        }

        #endregion
    }
}
