using UnityEngine;

namespace Behaviours
{
  public class MoveInConstantSpeed : MonoBehaviour
  {
    public Vector3 speed;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
      transform.position += speed * Time.deltaTime;
    }
  }
}
