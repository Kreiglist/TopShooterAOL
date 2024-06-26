using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private IMovement movement;
    private IShoot shoot;

    private void Awake()
    {
        movement = GetComponent<IMovement>();
        shoot = GetComponent<IShoot>();
    }

    private void Update()
    {
        movement.SetDirection(Input.GetAxisRaw("Horizontal"), 0f);

        if (Input.GetKey(KeyCode.Space))
        {
            shoot.Shoot();
        }
    }
}