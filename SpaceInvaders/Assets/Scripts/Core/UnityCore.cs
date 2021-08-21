using Assets.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityCore : MonoBehaviour
{
    #region Fields

    private readonly IList<IUpdatable> _updatables = new List<IUpdatable>();

    #endregion

    #region Methods
    private void Update()
    {
        for (int i = 0; i < _updatables.Count; i++)
        {
            _updatables[i].Update();
        }
    }

    public void RegisterUpdatable(IUpdatable updatable)
    {
        _updatables.Add(updatable);
    }

    #endregion


}
