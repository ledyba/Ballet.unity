using UnityEngine;
using UnityEngine.InputSystem;

namespace Player
{
  public class Move : MonoBehaviour
  {
    private PlayerInput _playerInput;
    public Camera camera3d;
    
    private void Start()
    {
      _playerInput = GetComponent<PlayerInput>();
    }

    private void Update()
    {
      var move = _playerInput.currentActionMap["Move"].ReadValue<Vector2>();
      move *= Time.deltaTime * 10.0f;
      var trans = transform;
      var pos = trans.position;
      pos.x += move.x;
      pos.y += move.y;

      var vp = camera3d.WorldToViewportPoint(pos);
      vp.y = Mathf.Clamp(vp.y, 0.05f, 0.95f);
      vp.x = Mathf.Clamp(vp.x, 0.3f, 0.7f);

      trans.position = camera3d.ViewportToWorldPoint(vp);
    }

  }
}