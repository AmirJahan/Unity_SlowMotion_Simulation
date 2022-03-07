using UnityEngine;

/*
 * Force	Add a continuous force to the rigidbody, using its mass.
Acceleration	Add a continuous acceleration to the rigidbody, ignoring its mass.
Impulse	Add an instant force impulse to the rigidbody, using its mass.
VelocityChange	Add an instant velocity change to the rigidbody, ignoring its mass.
 */
public enum Mode { Happy, Sad, Neutal }

public class RigidbodyDefinitions : MonoBehaviour
{
    // this is an enum, if you are n0t familiar, look at the example above (not used in this script)
    public ForceMode mode;

    [SerializeField] float mult = 10f;

    Rigidbody rigidbody;

    private void Start()
    {
        rigidbody = this.GetComponent<Rigidbody>();

        // smooth out the effect of running physics at a fixed frame rate, used for main characters
        rigidbody.interpolation = RigidbodyInterpolation.Interpolate;

        // Engine guesses the next position
        rigidbody.interpolation = RigidbodyInterpolation.Extrapolate;


        // for objects that fast moving object collide with
        rigidbody.collisionDetectionMode = CollisionDetectionMode.Continuous;

        // fast moving objects
        rigidbody.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;

        // cheaper and for kinematic objects
        rigidbody.collisionDetectionMode = CollisionDetectionMode.ContinuousSpeculative;

        // default (no issues with fast moving objects)
        rigidbody.collisionDetectionMode = CollisionDetectionMode.Discrete;

        // slow down an object. The higher the drag the more the object slows down
        rigidbody.drag = 10f;

        // slow down the rotation of an object.
        rigidbody.angularDrag = 10f;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // forces are dampened by the Drag
            rigidbody.AddForce(Vector3.up * mult, mode);
        }

    }
}