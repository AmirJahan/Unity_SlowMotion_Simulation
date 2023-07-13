using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour {
    // Slow mo Game Manager
    [SerializeField] GameObject sample;

    public ArrayList allCubes;

    void Start() {
        allCubes = new ArrayList();
        for (int x = -5; x < 6; x++) {
            for (int z = -5; z < 6; z++) {
                for (int y = 6; y < 18; y++) {
                    GameObject clone = GameObject.Instantiate(sample, new Vector3(x, y, z), Quaternion.identity);
                    clone.transform.localScale = new Vector3(.9f, .9f, .9f);
                    clone.GetComponent<Rigidbody>().isKinematic = false;

                    allCubes.Add(clone);
                }
            }
        }
    }
}
