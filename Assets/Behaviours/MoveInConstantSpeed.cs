using UnityEngine;

namespace Behaviours
{
  public class MoveInConstantSpeed : MonoBehaviour
  {
    public Vector3 speed;

    private GameObject _body;
    // Start is called before the first frame update
    private void Start()
    {
      _body = this.gameObject;
    }

    // Update is called once per frame
    private void Update()
    {
      _body.transform.position += speed * Time.deltaTime;
    }
  }
}
