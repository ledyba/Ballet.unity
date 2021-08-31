using System;
using UnityEngine;

namespace Behaviours.Ship
{
  public class Body : MonoBehaviour
  {
    public double life = 100.0;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
      Debug.Log("Collided");
      this.life -= 100;
    }
  }
}