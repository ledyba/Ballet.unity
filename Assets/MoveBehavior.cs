using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MoveBehavior : MonoBehaviour
{
  private Gamepad _pad;
  // Start is called before the first frame update
  void Start()
  {
    Debug.Log(Gamepad.all.Count);
    this._pad = Gamepad.all[0];
  }

  // Update is called once per frame
  void Update()
  {
    var pad = this._pad;
    if (pad.dpad.down.isPressed)
    {
      transform.Translate(0, -0.01f, 0);
    }
    if (pad.dpad.up.isPressed)
    {
      transform.Translate(0, 0.01f, 0);
    }
    if (pad.dpad.left.isPressed)
    {
      transform.Translate(-0.01f, 0, 0);
    }
    if (pad.dpad.right.isPressed)
    {
      transform.Translate(0.01f, 0, 0);
    }

  }
}
