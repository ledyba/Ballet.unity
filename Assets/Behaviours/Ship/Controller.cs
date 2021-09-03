using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Playables;

namespace Behaviours.Ship
{
  public class Controller : MonoBehaviour
  {
    private const float Diagonal = 0.70710678118f;
    
    private struct Input
    {
      public bool Up;
      public bool Down;
      public bool Left;
      public bool Right;
    }
  
    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
      var input = new Input();
      foreach (var pad in Gamepad.all)
      {
        UpdateGamepad(pad, ref input);
      }
      UpdateKeyboard(Keyboard.current, ref input);
      var x = 0;
      var y = 0;
      if (input.Up)
      {
        y++;
      }
      if (input.Down)
      {
        y--;
      }

      if (input.Left)
      {
        x--;
      }
      if (input.Right)
      {
        x++;
      } 
      var dx = 0.0f;
      var dy = 0.0f;
      switch((x,y))
      {
        case (-1, -1):
          dx = -Diagonal;
          dy = -Diagonal;
          break;
        case (-1, 0):
          dx = -1;
          break;
        case (-1, 1):
          dx = -Diagonal;
          dy = Diagonal;
          break;
        case (0, -1):
          dy = -1;
          break;
        case (0, 0):
          break;
        case (0, 1):
          dy = 1;
          break;
        case (1, -1):
          dx = Diagonal;
          dy = -Diagonal;
          break;
        case (1, 0):
          dx = 1;
          break;
        case (1, 1):
          dx = Diagonal;
          dy = Diagonal;
          break;
      }

      var trans = transform;
      var pos = trans.position;
      pos.x += dx;
      pos.y += dy;
      trans.position = pos;
      Debug.Log($"Move: {dx}, {dy}");
    }

    private void UpdateKeyboard(Keyboard key, ref Input input)
    {
      if (key == null)
      {
        return;
      }

      if (key.downArrowKey.isPressed)
      {
        input.Down = true;
      }

      if (key.upArrowKey.isPressed)
      {
        input.Up = true;
      }

      if (key.leftArrowKey.isPressed)
      {
        input.Left = true;
      }

      if (key.rightArrowKey.isPressed)
      {
        input.Right = true;
      }
    }

    private void UpdateGamepad(Gamepad pad, ref Input input)
    {
      if (pad.dpad.down.isPressed)
      {
        input.Down = true;
      }

      if (pad.dpad.up.isPressed)
      {
        input.Up = true;
      }

      if (pad.dpad.left.isPressed)
      {
        input.Left = true;
      }

      if (pad.dpad.right.isPressed)
      {
        input.Right = true;
      }
    }
  }
}