using UnityEngine;

public class DrawCollisionNormals : MonoBehaviour {
    private void OnCollisionEnter(Collision collision) {
        Debug.Log("Collision poision is: " + collision.contacts[0].point);

        Vector3 startPoint = collision.contacts[0].point;
        Vector3 direction = collision.contacts[0].normal;
        float rayLength = 3f;
        Color rayColor = Color.cyan;
        float rayDuration = 1.5f;

        Debug.DrawRay(startPoint, direction * rayLength, rayColor, rayDuration);
    }
}
