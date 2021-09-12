using System;
using UnityEngine;

namespace Enemy
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
