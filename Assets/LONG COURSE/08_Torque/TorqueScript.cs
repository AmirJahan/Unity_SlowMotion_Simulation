using UnityEngine;

public class TorqueScript : MonoBehaviour
{
    [SerializeField] float speed = 10f;

    void Update()
    {
        float hor = Input.GetAxis("Horizontal") * speed;
        gameObject.GetComponent<Rigidbody>().AddTorque(gameObject.transform.up * hor);
    }
}
