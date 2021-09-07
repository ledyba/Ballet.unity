using System;
using UnityEngine;

namespace Behaviours.Ship
{
  public class Body : MonoBehaviour
  {
    public double life = 100.0;

    private void OnTriggerEnter2D(Collider2D other)
    {
      Debug.Log("Collided");
      this.life -= 100;
    }
  }
}