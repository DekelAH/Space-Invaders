using Assets.Interfaces;
using Assets.Scripts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Models
{
    public class Player : MonoBehaviour, IModelActions
    {
        #region Fields

        [SerializeField] int health = 100;
        [SerializeField] float speed = 10f;

        #endregion

        #region Methods

        public void Move(float horizontal)
        {
            var deltaX = horizontal * speed * Time.deltaTime;
            var newX = transform.position.x + deltaX;
            transform.position = new Vector2(newX, transform.position.y);
        }

        public void Shoot()
        {
            throw new NotImplementedException();
        }


        #endregion
    }
}
