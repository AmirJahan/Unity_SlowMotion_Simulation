using UnityEngine;

public class MineField_Trigger : MonoBehaviour {
    [SerializeField] float pushFactor = 20f;
    [SerializeField] float rotationFactor = 20f;

    private void OnTriggerEnter(Collider other) {
        other.transform.GetComponent<Rigidbody>().AddForce(Vector3.up * pushFactor);
    }

    private void OnTriggerStay(Collider other) {
        other.transform.GetComponent<Rigidbody>().AddForce(Vector3.up * pushFactor);
        other.transform.GetComponent<Rigidbody>().AddTorque(Random.insideUnitSphere * rotationFactor);
    }
}
