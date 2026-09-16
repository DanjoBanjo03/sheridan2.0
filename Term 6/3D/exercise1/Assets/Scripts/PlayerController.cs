using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{

    private CharacterController characterController;

    private Vector2 move;

    [SerializeField] private float speed = 5f;
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    public void OnMove(InputValue value)
    {
        move = value.Get<Vector2>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movDir=
            (move.y * transform.forward) + 
            (move.x * transform.right);

        movDir.y = 0;

        characterController.Move(
            movDir * Time.deltaTime * speed
        );
    }
}
