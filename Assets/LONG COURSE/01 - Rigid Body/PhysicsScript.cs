using UnityEngine;

public class S_1_PhysicsScript : MonoBehaviour {
    Rigidbody rb;

    void Awake() {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // better for phsycis
    void FixedUpdate() {
        rb.velocity = new Vector3(1, 0, 0);
    }
}
