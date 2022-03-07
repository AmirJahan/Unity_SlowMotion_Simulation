using UnityEngine;

public class MonkeyJump : MonoBehaviour
{
    [SerializeField] float jumpPower = 10f;

    void Update()
    {
        if (Input.GetKeyUp (KeyCode.Space))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpPower;
        }
    }
}
