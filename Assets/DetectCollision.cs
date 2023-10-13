using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public AudioSource audioPlayer;
    public GameObject winText;
    public GameObject ReloadGame;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        
        Destroy(gameObject);
        winText.SetActive(true);
        ReloadGame.SetActive(true);
        audioPlayer.Play();
        
    }
}
