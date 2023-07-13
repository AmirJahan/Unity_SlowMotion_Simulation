using UnityEngine;

public class GameObjectColorScript : MonoBehaviour {
    // we wnt to get 5 game objects
    [SerializeField] GameObject obj_1;

    private void Update() {
        if (Input.GetMouseButtonUp(0)) {
            int myRandom = Random.Range(1, 6);
            float r = Random.Range(0.0f, 1.0f);
            float g = Random.Range(0.0f, 1.0f);
            float b = Random.Range(0.0f, 1.0f);

            Color myRandomColor = new Color(r, g, b);

            switch (myRandom) {
                case 1:
                    obj_1.GetComponent<Renderer>().material.color = myRandomColor;
                    break;
                default:
                    break;
            }

            // if (myRandom == 1)
            //     obj_1.GetComponent<Renderer> ().material.color = myRandomColor;
            // else if (myRandom == 2)
            //     obj_2.GetComponent<Renderer> ().material.color = myRandomColor;
            // else if (myRandom == 3)
            //     obj_3.GetComponent<Renderer> ().material.color = myRandomColor;
            // else if (myRandom == 4)
            //     obj_4.GetComponent<Renderer> ().material.color = myRandomColor;
            // else if (myRandom == 5)
            //     obj_5.GetComponent<Renderer> ().material.color = myRandomColor;
        }
    }
}
