using UnityEngine;

public class MineField_PlayerScript : MonoBehaviour {
    [SerializeField] float speed = 10f;

    void FixedUpdate() {
        float x = Input.GetAxis("Horizontal"); // ad
        float y = 0;
        float z = Input.GetAxis("Vertical"); // ws
        Vector3 move = new Vector3(x, y, z);

        transform.Translate(move * speed * Time.deltaTime);
    }
}
