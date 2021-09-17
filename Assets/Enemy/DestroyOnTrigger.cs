using System;
using UnityEngine;

namespace Enemy
{
  public class DestroyOnTrigger: MonoBehaviour
  {
    private void OnTriggerEnter2D(Collider2D other)
    {
      Destroy(gameObject);
    } 
  }
}
