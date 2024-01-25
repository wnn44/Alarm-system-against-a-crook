using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float Speed = 10f;
    public float JumpForce = 300f;

    void FixedUpdate()
    {
        Movement();
    }

    private void Movement()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        transform.Translate(movement * Speed * Time.deltaTime);
    }
}
