using Assets.GameInput;
using Assets.Interfaces;
using Assets.Scripts.Factories;
using Assets.Scripts.GameSpawn;
using Assets.Scripts.Interfaces;
using Assets.Scripts.Models;
using UnityEngine;

namespace Assets.Services
{
    public static class GamePlayServices
    {
        #region Fields

        private static UnityCore _unityCore;

        #endregion

        #region Properties

        public static ICoroutineServices CoroutineServices => _unityCore;

        #endregion

        #region Methods

        public static void Initialize()
        {
            var go = new GameObject("UnityCore");
            _unityCore = go.AddComponent<UnityCore>();

            IUpdatable sim = new GameInputManager();
            _unityCore.RegisterUpdatable(sim);

            IStartable st = new SpawnManager();
            _unityCore.RegisterStartable(st);

            Object.DontDestroyOnLoad(go);
        }

        #endregion


    }
}
