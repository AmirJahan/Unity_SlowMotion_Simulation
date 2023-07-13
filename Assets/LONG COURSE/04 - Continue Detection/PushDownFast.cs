using UnityEngine;

public class PushDownFast : MonoBehaviour {
    void Update() {
        gameObject.GetComponent<Rigidbody>().velocity =
                    new Vector3(0, -100, 0);
    }
}
