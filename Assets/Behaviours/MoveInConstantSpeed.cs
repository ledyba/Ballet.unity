using UnityEngine;

namespace Behaviours
{
  public class MoveInConstantSpeed : MonoBehaviour
  {
    public Vector3 speed;

    // Update is called once per frame
    private void Update()
    {
      transform.position += speed * Time.deltaTime;
    }
  }
}
