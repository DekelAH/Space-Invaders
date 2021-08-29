using Assets.Interfaces;
using Assets.Scripts.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityCore : MonoBehaviour, ICoroutineServices
{
    #region Fields

    private readonly IList<IUpdatable> _updatables = new List<IUpdatable>();
    private readonly IList<IStartable> _startables = new List<IStartable>();

    #endregion

    #region Methods

    private void Start()
    {
        for (int i = 0; i < _startables.Count; i++)
        {
            _startables[i].Start();
        }
    }

    private void Update()
    {
        for (int i = 0; i < _updatables.Count; i++)
        {
            _updatables[i].Update();
        }
    }

    public void RegisterStartable(IStartable startable)
    {
        _startables.Add(startable);
    }

    public void RegisterUpdatable(IUpdatable updatable)
    {
        _updatables.Add(updatable);
    }

    public Coroutine RunCoroutine(IEnumerator coroutineBody)
    {
        return StartCoroutine(coroutineBody);
    }

    public void EndCoroutine(Coroutine coroutine)
    {
        StopCoroutine(coroutine);
    }

    public void WaitFor(float delaySeconds)
    {
       RunCoroutine(WaitForInternal(delaySeconds));
    }

    private IEnumerator WaitForInternal(float delaySeconds)
    {
        yield return new WaitForSeconds(delaySeconds);
    }

    #endregion


}
