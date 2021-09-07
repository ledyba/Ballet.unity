using System;
using UnityEngine;

namespace Behaviours.Enemy
{
  public class Destroy: MonoBehaviour
  {
    private void OnTriggerEnter2D(Collider2D other)
    {
      Debug.Log("Trigger: "+ other.gameObject.name);
      Destroy(gameObject);
    }
  }
}
