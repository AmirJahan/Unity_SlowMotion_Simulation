using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// we need this for gettIng "All" from the array
using System.Linq;

public class SimulationScript : MonoBehaviour
{
    [SerializeField]
    int numberOfIterations = 100;

    // we use this declaration to access the reset 
    MyBody[] bodies;

    // to be used without LINQ
    ArrayList bodies2;


    [ContextMenu("Simulate")]
    void Simulate()
    {
        // first turn off the auto, turn it on at the end
        Physics.autoSimulation = false;


        // this is WITHOUT LINQ
        Rigidbody[] rbs = FindObjectsOfType<Rigidbody>();
        bodies2 = new ArrayList();
        foreach (Rigidbody rb in rbs)
        {
            bodies2.Add(new MyBody(rb));
        }


        // This is approach with LINQ
        bodies = FindObjectsOfType<Rigidbody>().Select(rigidbody => new MyBody(rigidbody)).ToArray();


        for (int i = 0; i < numberOfIterations; i++)
        {
            Physics.Simulate(Time.fixedDeltaTime);


            // without LINQ
            bool done = true;
            foreach (MyBody myBidy in bodies2)
            {
                if (!myBidy.rigidbody.IsSleeping())
                {
                    done = false;
                }
            }

            if (done) break;

            // with LINQ
            //if (bodies.All(body => body.rigidbody.IsSleeping()))
            //    break;
        }

        Physics.autoSimulation = true;
    }

    [ContextMenu("Reset")]
    void Reset ()
    {
        foreach (MyBody body in bodies)
        {
            body.Reset();
        }
    }


    // without MyBody, we can't reset the positions
    struct MyBody
    {
        public readonly Rigidbody rigidbody;
        public readonly Transform transform;
        public readonly Vector3 resetPosition;

        public MyBody (Rigidbody rigidbody)
        {
            this.rigidbody = rigidbody;
            this.transform = rigidbody.transform;
            resetPosition = rigidbody.position;
        }

        public void Reset ()
        {
            transform.position = resetPosition;
        }
    }
}
