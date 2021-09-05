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
    public Camera camera3d;
    
    // Start is called before the first frame update
    private void Start()
    {
      _input = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    private void Update()
    {
      var move = _input.currentActionMap["Move"].ReadValue<Vector2>();
      move *= Time.deltaTime;
      move *= 10.0f;
      var trans = transform;
      var pos = trans.position;
      pos.x += move.x;
      pos.y += move.y;

      var vp = camera3d.WorldToViewportPoint(pos);
      vp.y = Mathf.Clamp(vp.x, 0.05f, 0.95f);
      vp.x = Mathf.Clamp(vp.x, 0.3f, 0.7f);

      trans.position = camera3d.ViewportToWorldPoint(vp);
    }

  }
}