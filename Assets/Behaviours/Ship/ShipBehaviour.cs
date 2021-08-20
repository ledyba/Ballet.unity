using UnityEngine;
using UnityEngine.InputSystem;

namespace Behaviours.Ship
{
  
public class ShipBehaviour : MonoBehaviour
{
  private Gamepad _pad;
  private Keyboard _keyboard;
  // Start is called before the first frame update
  void Start()
  {
    Debug.Log(Gamepad.all.Count);
    Debug.Log(Keyboard.KeyCount);
    this._keyboard = Keyboard.current;
    this._pad = Gamepad.current;
  }

  // Update is called once per frame
  void Update()
  {
    this.UpdateGamepad();
    this.UpdateKeybaord();
  }

  private void UpdateKeybaord()
  {
    var key = this._keyboard;
    if (key == null)
    {
      return;
    }

    if (key.downArrowKey.isPressed)
    {
      transform.Translate(0, -0.01f, 0);
    }
    if (key.upArrowKey.isPressed)
    {
      transform.Translate(0, +0.01f, 0);
    }
    if (key.leftArrowKey.isPressed)
    {
      transform.Translate(-0.01f, 0, 0);
    }
    if (key.rightArrowKey.isPressed)
    {
      transform.Translate(+0.01f, 0, 0);
    }

  }

  private void UpdateGamepad()
  {
    var pad = this._pad;
    if (pad == null)
    {
      return;
    }
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

}