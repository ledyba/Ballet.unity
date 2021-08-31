using UnityEngine;

namespace Behaviours.Ship
{
  public class RotateZ : MonoBehaviour
  {
    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
      transform.Rotate(0.0f, 0.0f, -180 * Time.deltaTime);
    }
  }
}