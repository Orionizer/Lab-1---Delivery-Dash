using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] float Speed = 5f;
    [SerializeField] float SpeedMult = 0.01f;
    [SerializeField] float Friction = 0.005f;
    [SerializeField] float TurnSpeed = 1f;
    float Acceleration = 0f;
    float velocity = 0f;
    float turnSpeed = 0f;
    float friction = 0f;

    // Update is called once per frame
    void Update()
    {
        velocity = Speed * Acceleration;
        turnSpeed = TurnSpeed * velocity;
        friction = Friction * Mathf.Abs(Acceleration);

        transform.Translate(0f, velocity * SpeedMult, 0f);
        if (velocity > 0.01f)
        {
            Acceleration -= friction;
        }
        else if (velocity < 0.01f)
        {
            Acceleration += friction;
        }

        if (Keyboard.current.wKey.isPressed)
        {
            Acceleration += 0.01f;
        }
        else if (Keyboard.current.sKey.isPressed)
        {
            Acceleration -= 0.01f;
        }
        if (Keyboard.current.aKey.isPressed)
        {
            transform.Rotate(0f, 0f, turnSpeed);
        }
        if (Keyboard.current.dKey.isPressed)
        {
            transform.Rotate(0f, 0f, -1 * turnSpeed);
        }
    }
}
