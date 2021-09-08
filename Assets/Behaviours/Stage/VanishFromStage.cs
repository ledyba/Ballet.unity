using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Playables;

namespace Behaviours
{
  public class VanishFromStage : MonoBehaviour
  {
    public Camera camera3d;
    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
      var children = GetComponentsInChildren<Transform>();
      if (children.Length == 0) {
        return;
      }

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