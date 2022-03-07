using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    private void OnTriggerEnter (Collider other)
    {
        print ("We entered");
    }

    private void OnTriggerStay (Collider other)
    {
        print ("We are inside the trigger");
    }

    private void OnTriggerExit (Collider other)
    {
        print ("We exited the trigger");
    }
}