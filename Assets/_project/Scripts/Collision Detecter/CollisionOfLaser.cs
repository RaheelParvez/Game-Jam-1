using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionOfLaser : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
         
        }
    }
}
