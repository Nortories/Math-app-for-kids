using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherDontDestroy : MonoBehaviour
{
    private static AnotherDontDestroy instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
