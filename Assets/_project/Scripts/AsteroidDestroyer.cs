using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AsteroidDestroyer : MonoBehaviour
{

    public Scoring score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            score.AddScore(1);
            score.UpdateScore();

        }


    }

   
}

