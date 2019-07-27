using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateManager : MonoBehaviour
{
    // 각 프로젝트에서 사용하는 싱글톤으로 바꿔주자.
    private static UpdateManager instance = null;
    public static UpdateManager Instance
    {
        get
        {
            if (instance == null)
            {
                GameObject temp = new GameObject("UpdateManager");
                instance = temp.AddComponent<UpdateManager>();
            }
            return instance;
        }
    }

    private List<BaseMonoBehaviour> baseMonoBehaviours = new List<BaseMonoBehaviour>();

    void Update()
    {
        for (int i = 0; i < instance.baseMonoBehaviours.Count; ++i)
        {
            instance.baseMonoBehaviours[i].OnUpdate();
        }
    }

    public void RegisterMonoBehaviour(BaseMonoBehaviour obj)
    {
        if (instance.baseMonoBehaviours.Contains(obj) == false)
        {
            instance.baseMonoBehaviours.Add(obj);
        }
    }

    public void DeregisterMonoBehaviour(BaseMonoBehaviour obj)
    {
        if (instance.baseMonoBehaviours.Contains(obj) == true)
        {
            instance.baseMonoBehaviours.Remove(obj);
        }
    }
}
