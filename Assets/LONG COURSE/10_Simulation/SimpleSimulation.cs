using UnityEngine;
using System.Linq;

public class SimpleSimulation : MonoBehaviour {
    [SerializeField]
    int numberOfIterations = 100;

    // we use this declaration to access the reset
    Rigidbody[] bodies;

    [ContextMenu("Simulate")]
    void Simulate() {
        // first turn off the auto, turn it on at the end
        Physics.autoSimulation = false;

        // we use rigibodies first
        //Rigidbody[] rigidbodies = FindObjectsOfType<Rigidbody>();

        // but then we replace it with my bodies
        bodies = FindObjectsOfType<Rigidbody>();

        for (int i = 0; i < numberOfIterations; i++) {
            Physics.Simulate(Time.fixedDeltaTime);

            // if we are using MyBody array, we have to change this as well
            if (bodies.All(any => any.IsSleeping()))
                break;
        }

        Physics.autoSimulation = true;
    }
}
