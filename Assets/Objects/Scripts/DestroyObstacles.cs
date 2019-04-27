using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObstacles : MonoBehaviour
{
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Block")
        {
            print("chefesfefs");
            Destroy(other);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
