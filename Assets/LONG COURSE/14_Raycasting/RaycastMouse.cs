using UnityEngine;

public class RaycastMouse : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            Transform objectHit = hit.transform;
            print("name is: " + objectHit.transform.name);
        }
    }
}
