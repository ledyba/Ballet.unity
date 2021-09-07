using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Playables;
using UnityEngine.Serialization;

namespace Behaviours.Ship
{
  public class Attack : MonoBehaviour
  {
    private PlayerInput _input;
    public GameObject stage;
    public GameObject bullet;
    
    // Start is called before the first frame update
    private void Start()
    {
      _input = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    private void Update()
    {
      var attacked = _input.currentActionMap["Attack"].triggered;
      if (attacked)
      {
        Instantiate(bullet, transform.position, Quaternion.identity, stage.transform);
      }
    }

  }
}