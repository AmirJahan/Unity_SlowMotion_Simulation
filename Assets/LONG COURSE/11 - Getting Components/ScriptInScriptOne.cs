using UnityEngine;

public class ScriptInScriptOne : MonoBehaviour {
    void Start() {
        gameObject.GetComponent<ScriptInScriptTwo>().someVal = 5;
    }
}
