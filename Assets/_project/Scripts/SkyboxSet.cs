using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Skybox))]

public class SkyboxSet : MonoBehaviour
{
    [SerializeField] List<Material> _skyboxMaterials;

    Skybox _skybox;

    // Update is called once per frame
    void Awake()
    {
        _skybox= GetComponent<Skybox>();
    }

    void OnEnable()
    { 
     ChangeSkybox(0);
    }
   
   void ChangeSkybox (int i)
   {
    
   }
}


