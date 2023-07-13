using UnityEngine;

public class Collisions : MonoBehaviour {
    public Transform explosionPrefab;

    void OnCollisionEnter(Collision collision) {
        ContactPoint contact = collision.contacts[0];
        Vector3 contactPosition = contact.point;

        Instantiate(explosionPrefab,
                    contactPosition,
                    Quaternion.identity);

        Destroy(gameObject);
    }

    private void OnCollisionExit(Collision other) {
    }

    private void OnCollisionStay(Collision other) {
    }
}
