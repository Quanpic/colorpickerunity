using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundAwake : MonoBehaviour
{
    private static BackgroundAwake _mesh;
        
    private void Awake()
    {
        if (_mesh == null)
        {
            _mesh = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(transform.gameObject);
    }
}
