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
        }

        if(Input.GetMouseButtonUp(0))
        {
            StopShooting();
        }
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