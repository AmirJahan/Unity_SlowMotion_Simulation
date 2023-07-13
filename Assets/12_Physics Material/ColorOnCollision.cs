using UnityEngine;

public class ColorOnCollision : MonoBehaviour {
    Renderer renderer;

    private void Awake() {
        // caching the renderer helps the speed
        renderer = gameObject.GetComponent<Renderer>();
    }

    private void OnCollisionEnter(Collision other) {
        Color newColor = Random.ColorHSV();
        renderer.material.color = newColor;
    }
}
