using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Playables;
using UnityEngine.Serialization;

namespace Ship
{
  public class Attack : MonoBehaviour
  {
    private PlayerInput _input;
    public GameObject stage;
    public GameObject bullet;
    
    private void Start()
    {
      _input = GetComponent<PlayerInput>();
    }

    private void Update()
    {
      if (_input.currentActionMap["Attack"].triggered)
      {
        Instantiate(bullet, transform.position, Quaternion.identity, stage.transform);
      }
    }

  }
}