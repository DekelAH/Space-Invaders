using Assets.Services;
using UnityEngine;

namespace Assets
{
    public sealed class EntryPoint: MonoBehaviour
    {
        private void Awake()
        {
            GamePlayServices.Initialize();
        }
    }
}
