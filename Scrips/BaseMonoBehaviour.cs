using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseMonoBehaviour : MonoBehaviour
{
    private void OnEnable()
    {
        UpdateManager.Instance.RegisterMonoBehaviour(this);
    }

    private void OnDisable()
    {
        UpdateManager.Instance.DeregisterMonoBehaviour(this);
    }

    public abstract void OnUpdate();
}
