using UnityEngine;

namespace Common {
  public class MoveInConstantSpeed : MonoBehaviour {
    public Vector3 speed;

    private void Update() {
      transform.position += speed * Time.deltaTime;
    }
  }
}