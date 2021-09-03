using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Playables;

namespace Behaviours.Ship
{
  public class Controller : MonoBehaviour
  {
    private const float Diagonal = 0.70710678118f;

    private PlayerInput _input;
    
    // Start is called before the first frame update
    private void Start()
    {
      _input = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    private void Update()
    {
      var move = _input.currentActionMap["Move"].ReadValue<Vector2>();
      var trans = transform;
      var pos = trans.position;
      pos.x += move.x * 0.025f;
      pos.y += move.y * 0.025f;
      trans.position = pos;
    }

  }
}