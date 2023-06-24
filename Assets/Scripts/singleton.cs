using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class singleton : MonoBehaviour
{
    private static singleton _instance;

    public static singleton Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<singleton>();
                if (_instance == null)
                {
                    _instance = new GameObject("GameManager").AddComponent<singleton>();
                }
            }
            return _instance;
        }
    }

    private void Awake()
    {
        if (Instance != null) Destroy(this);
        DontDestroyOnLoad(this);
    }
}
