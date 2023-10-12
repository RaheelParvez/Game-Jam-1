using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    [BoxGroup("Ship movement values")]
    [SerializeField]
    [Range(1000f, 1000f)]
    float _thrustForce = 7500f,
          _pitchForce = 6000f,
          _rollForce = 1000f,
          _yawForce = 2000f;
}
