using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Playables;

namespace Common
{
  public class VanishFromStage : MonoBehaviour
  {
    public Camera camera3d;

    private void Update()
    {
      foreach (Transform child in transform)
      {
        var vp = camera3d.WorldToViewportPoint(child.position);
        if (
          vp.y > 1 ||
          vp.y < 0 ||
          vp.x < 0.2 ||
          vp.x > 0.8)
        {
          Destroy(child.gameObject);
        }
      }
    }

  }
}