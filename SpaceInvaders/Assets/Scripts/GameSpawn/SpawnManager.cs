using Assets.Models;
using Assets.Scripts.Interfaces;
using Assets.Scripts.Models;
using Assets.Services;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.GameSpawn
{
    public class SpawnManager : IStartable
    {
        #region Methods

        public void Start()
        {
            GamePlayServices.CoroutineServices.RunCoroutine(SpawnRandomly());
        }

        public IEnumerator SpawnRandomly()
        {
            while (true)
            {
                float delaytime = Random.Range(2.0f, 5.0f);

                var spawnPosition = new Vector2(Random.Range(-4.6f, 4.67f), 10.0f);
                GamePlayElements.Instance.AstroidFactory.Create(spawnPosition, Quaternion.identity);
                GamePlayElements.Instance.Astroid.Move();

                yield return new WaitForSeconds(delaytime);
            }

        }

        #endregion
    }
}
