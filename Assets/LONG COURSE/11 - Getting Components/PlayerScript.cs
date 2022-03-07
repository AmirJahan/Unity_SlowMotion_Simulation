using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    void Start()
    {
        GameObject.Find("GameManager").GetComponent<ScoreScript>().scoreValue ++;
    }
}
