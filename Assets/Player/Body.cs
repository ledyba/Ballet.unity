using System;
using UnityEngine;

namespace Ship
{
  public class Body : MonoBehaviour
  {
    public double life = 100.0;

    private void OnTriggerEnter2D(Collider2D other)
    {
      Debug.Log("Collided");
      life -= 100;
    }
  }
}