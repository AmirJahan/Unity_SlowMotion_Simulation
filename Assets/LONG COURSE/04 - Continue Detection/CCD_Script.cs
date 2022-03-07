using UnityEngine;

public class CCD_Script : MonoBehaviour
{
    [SerializeField] GameObject[] collisionModes;
    // Start is called before the first frame update
    void Start ()
    {
        InvokeRepeating ("createBoxes", 1f, .1f);
    }

    void createBoxes ()
    {
        float randomXandZ = Random.Range (-8, 8);
        Vector3 newLoc = new Vector3 (randomXandZ, 10, randomXandZ);
        GameObject next = Instantiate (collisionModes[Random.Range (0, 4)],
                                       newLoc,
                                       Quaternion.identity);

        next.GetComponent<Renderer>().material.color = Random.ColorHSV(0f,
                                                                       1f,
                                                                       0f,
                                                                       1f,
                                                                       0f,
                                                                       1f);
        // you could write this with a switch as well
    }
}