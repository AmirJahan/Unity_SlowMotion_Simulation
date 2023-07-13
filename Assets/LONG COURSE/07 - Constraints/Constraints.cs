using UnityEngine;

public class Constraints : MonoBehaviour {
    void Start() {
        gameObject.GetComponent<Rigidbody>().constraints =
        RigidbodyConstraints.FreezeRotationX |
        RigidbodyConstraints.FreezeRotationY |
        RigidbodyConstraints.FreezePositionX;
    }
}
