using System;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Interfaces
{
    public interface ICoroutineServices
    {
        Coroutine RunCoroutine(IEnumerator coroutine);

        void EndCoroutine(Coroutine coroutineBody);

        void WaitFor(float delaySeconds);
    }
}
