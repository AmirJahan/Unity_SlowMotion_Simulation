using UnityEngine;

public class PhysicsScript : MonoBehaviour {
    //If you are doing this for a 2D object, remember to freeze the rotations

    [SerializeField] float speed = 10f;
    Rigidbody rigidbody;

    public Vector3 direction;

    void Start() {
        rigidbody = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    }

    // better for physics simulations (might run multiple times in a frame)
    void FixedUpdate() {
        // velocity is constant, no acceleration/decelaration
        rigidbody.velocity = direction * speed;

        // Or force has acceleration/deceleration
        rigidbody.AddForce(direction * speed);

        // or using move position, which is the same as Translate, but with consideration for phsyics
        // this'll look just like the Translate, but will detect collisions. 
        rigidbody.MovePosition(transform.position + (direction * speed * Time.deltaTime));
    }
}
