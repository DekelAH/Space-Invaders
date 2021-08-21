using Assets.GameInput;
using Assets.Interfaces;
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

            Object.DontDestroyOnLoad(go);
        }

        #endregion 
    }
}
