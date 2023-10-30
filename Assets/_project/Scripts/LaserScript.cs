using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour
{
    public AudioSource audioPlayer;
    public GameObject Laser;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Shoot();
            audioPlayer.Play();
            Invoke("StopShooting", 0.1f);
        }

<<<<<<< HEAD
=======
        
>>>>>>> 80eb1df5a90a42a5c91a1ea4283b657b548782bd
    }

    void Shoot()
    {
        Laser.SetActive(true);
    }

    void StopShooting()
    {
        Laser.SetActive(false);
    }
}