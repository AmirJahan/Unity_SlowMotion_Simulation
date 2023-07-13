using UnityEngine;

public class RaycastingScript : MonoBehaviour {
    [SerializeField] GameObject gun;
    [SerializeField] GameObject target;

    void Update() {
        if (Input.GetKeyUp(KeyCode.Space)) {
            Vector3 origin = gun.transform.position;
            Vector3 direction = target.transform.position - origin;

            float distance = 100f;

            RaycastHit hitInfo;

            Physics.Raycast(origin, direction, out hitInfo, distance); // layermask is the layer to ignore

            print("Found an object: " + hitInfo.transform.name + " at - distance: " + hitInfo.distance);
        }
    }
}
