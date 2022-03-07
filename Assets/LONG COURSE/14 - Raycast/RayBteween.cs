using UnityEngine;

public class RayBteween : MonoBehaviour {

    public GameObject targetObj;

    void Update () 
    {
        float maxRange = 500;
        RaycastHit hit;

        if (Vector3.Distance (transform.position, targetObj.transform.position) < maxRange) 
        {
            if (Physics.Raycast (transform.position, 
                                 (targetObj.transform.position - transform.position),
                                  out hit, 
                                  maxRange)) 
            {
                // if (hit.transform == targetObj.transform) {
                    
                    print("hit");
                    Debug.DrawRay(transform.position, 
                                  (targetObj.transform.position - transform.position),
                                   Color.red);

                // }
            }
        }
    }
}