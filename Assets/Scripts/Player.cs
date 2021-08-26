using UnityEngine;

public class Player : MonoBehaviour
{
  private InputActions _ia;
  private Vector2 _stickVector;
  // Start is called before the first frame update
  private Rigidbody _rb;
  public float speed;
  public UIManager uIManager;

  void Awake()
  {
    _rb = this.gameObject.GetComponent<Rigidbody>();
    _ia = new InputActions();
  }

  // Update is called once per frame
  void FixedUpdate()
  {
    _stickVector = _ia.Player.Move.ReadValue<Vector2>();
    _rb.AddForce(new Vector3(_stickVector.x, 0f, _stickVector.y) * speed, ForceMode.Acceleration);
  }

  void OnEnable()
  {
    _ia.Player.Enable();
  }

  void OnDisable()
  {
    _ia.Player.Disable();
  }

  void OnCollisionEnter(Collision other)
  {
    if (other.gameObject.CompareTag("Item"))
    {
      Destroy(other.gameObject);
      uIManager.NumItems--;
    }
  }
}
