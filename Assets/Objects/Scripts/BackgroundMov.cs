using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMov : MonoBehaviour
{
    public float speed;
    public Renderer rend;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rend.material.mainTextureOffset += new Vector2(0f, speed * Time.deltaTime);
    }
}
