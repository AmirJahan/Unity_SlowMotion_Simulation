using UnityEngine;

public class S_2_RigidBodyScript : MonoBehaviour
{
	Rigidbody rb;
	// Start is called before the first frame update
	void Start ()
	{
		rb = gameObject.GetComponent<Rigidbody> ();

		rb.mass = 1;
		rb.angularDrag = 1;
		rb.AddForce (1, 0, 0, ForceMode.Impulse);

		rb.AddForce (Vector3.up * 10);

		rb.centerOfMass = new Vector3 (0, -20, 0);

		rb.collisionDetectionMode = CollisionDetectionMode.Continuous;

		rb.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;

		rb.collisionDetectionMode = CollisionDetectionMode.Discrete;

		rb.freezeRotation = true;

		print (rb.angularVelocity.magnitude);

		rb.drag = 20;

	
		rb.isKinematic = true;

		rb.velocity = new Vector3 (0, 10, 0);

	}
}