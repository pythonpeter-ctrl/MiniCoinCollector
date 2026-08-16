using UnityEngine;

public class TestSquareController : MonoBehaviour
{
    [SerializeField] private float speed = 5f;

    private InputSystem_Actions inputActions;

    private void Awake()
    {
        inputActions = new InputSystem_Actions();
    }

    private void OnEnable()
    {
        inputActions.Enable();
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }

    void Update()
    {
        Vector2 movement = inputActions.Player.Move.ReadValue<Vector2>();

        transform.Translate(movement * speed * Time.deltaTime);
    }
}