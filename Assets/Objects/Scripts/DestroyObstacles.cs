using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObstacles : MonoBehaviour
{
    //public GameObject block;
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Block")
        {
            Destroy(other.gameObject);
        }

//        if (other.tag == "DestroyBlockEffect")
//        {
//            Destroy(other.GetComponent<ParticleSystem>());
//        }
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
