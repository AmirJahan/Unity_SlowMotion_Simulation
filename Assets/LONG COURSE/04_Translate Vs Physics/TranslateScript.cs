using UnityEngine;

public class TranslateScript : MonoBehaviour
{
    [SerializeField] float speed = 10f;

    void Update()
    {
        float x = Input.GetAxis("Horizontal"); // ad
        float y = 0;
        float z = Input.GetAxis("Vertical"); // ws
        Vector3 move = new Vector3(x, y, z);

        transform.Translate(move * speed * Time.deltaTime);
    }
}
