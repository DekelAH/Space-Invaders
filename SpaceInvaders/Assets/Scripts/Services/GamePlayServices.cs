using Assets.GameInput;
using Assets.Interfaces;
using Assets.Scripts.GameSpawn;
using UnityEngine;

namespace Assets.Services
{
    public static class GamePlayServices
    {
        #region Fields

        private static UnityCore _unityCore;

        #endregion

        #region Methods

        public static void Initialize()
        {
            var go = new GameObject("UnityCore");
            _unityCore = go.AddComponent<UnityCore>();

            IUpdatable sim = new GameInputManager();
            _unityCore.RegisterUpdatable(sim);

            IUpdatable spawn = new SpawnManager();
            _unityCore.RegisterUpdatable(spawn);

            Object.DontDestroyOnLoad(go);
        }

        #endregion 
    }
}
