using UnityEngine;
using UnityEngine.InputSystem;

namespace Player {
  public class Attack : MonoBehaviour {
    private PlayerInput input_;
    public GameObject stage;
    public GameObject bullet;

    private void Start() {
      input_ = GetComponent<PlayerInput>();
    }

    private void Update() {
      if (input_.currentActionMap["Attack"].triggered) {
        Instantiate(bullet, transform.position, Quaternion.identity, stage.transform);
      }
    }
  }
}