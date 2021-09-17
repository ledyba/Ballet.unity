using UnityEngine;

namespace Player
{
  public class Body : MonoBehaviour
  {
    public double life = 100.0;

    private void OnTriggerEnter2D(Collider2D other)
    {
      life -= 100;
    }
  }
}