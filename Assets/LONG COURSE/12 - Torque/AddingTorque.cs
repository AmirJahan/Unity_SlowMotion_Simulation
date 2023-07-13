using UnityEngine;

public class AddingTorque : MonoBehaviour {
    public float torque = 1f;
    Rigidbody rb;

    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate() {
        float turn = Input.GetAxis("Horizontal");
        rb.AddTorque(transform.up * torque * turn);
    }
}
