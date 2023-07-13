using UnityEngine;

public class FindGameObject : MonoBehaviour {
    GameObject toFind;

    void Start() {
        toFind = GameObject.Find("MyObjectAtThatLocatiobn");

        // you don't necessarily need to store the GameObject
        GameObject.Find("TheObject I am Looking for").SetActive(false);
        Destroy(toFind);

        // to search for objects in group
        toFind = GameObject.Find("TopParent/MiddleParent/Child");
        Destroy(toFind);

        // to search with tag, this will only keep the last found one
        toFind = GameObject.FindWithTag("EnemyTag");
        Destroy(toFind);

        GameObject[] foundObj = GameObject.FindGameObjectsWithTag("EnemyTag");

        foreach (GameObject any in foundObj) {
            Destroy(any);
        }
    }
}
