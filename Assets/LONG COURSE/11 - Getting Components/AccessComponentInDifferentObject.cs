using UnityEngine;

public class AccessComponentInDifferentObject : MonoBehaviour {
    void Start() {
        // in an entirely different object
        GameObject.Find("SearchObject").GetComponent<Renderer>().material.color = Color.blue;

        // in children or parent
        gameObject.GetComponentInChildren<Rigidbody>().useGravity = false;
        gameObject.GetComponentInParent<Rigidbody>().useGravity = false;
    }
}
