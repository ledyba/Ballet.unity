using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Playables;

namespace Behaviours.Ship
{
  public class Controller : MonoBehaviour
  {
    private Gamepad _pad;

    private Keyboard _keyboard;

    // Start is called before the first frame update
    private void Start()
    {
      Debug.Log($"Gamepads: {Gamepad.all.Count}", gameObject);
      Debug.Log($"Keys: {Keyboard.KeyCount}", gameObject);
      _keyboard = Keyboard.current;
      _pad = Gamepad.current;
    }

    // Update is called once per frame
    private void Update()
    {
      UpdateGamepad();
      UpdateKeyboard();
    }

    private void UpdateKeyboard()
    {
      var key = _keyboard;
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
      var pad = _pad;
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