using UnityEngine;

public class RayCasting : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 1000))
            {
                print(hit.transform.gameObject.name);
                Destroy(hit.transform.gameObject);
            }
        }
    }
}
