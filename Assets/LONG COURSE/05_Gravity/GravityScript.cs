using UnityEngine;

public class GravityScript : MonoBehaviour
{
    Rigidbody rigidbody;
    float gJupiter = 2.528f;  //gravity on the Jupiter.

    private void Awake()
    {
        rigidbody = gameObject.GetComponent<Rigidbody>();
    }


    void Start()
    {
        // this is global for all objects
        Physics.gravity = new Vector3(0, -1.0F, 0);

        // to programatically disable / enable gravity
        rigidbody.useGravity = true;
    }


    void FixedUpdate()
    {
        rigidbody.AddForce(Vector3.down * rigidbody.mass * gJupiter);
    }
}
