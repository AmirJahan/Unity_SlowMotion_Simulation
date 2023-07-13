using UnityEngine;

public class AccessComponent : MonoBehaviour {
    void Start() {
        gameObject.GetComponent<Transform>().position = new Vector3(10, 0, 0);

        gameObject.GetComponent<Renderer>().material.color = Color.black;
    }
}
