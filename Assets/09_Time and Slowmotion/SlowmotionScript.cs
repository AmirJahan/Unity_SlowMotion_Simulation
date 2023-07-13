using UnityEngine;

public class SlowmotionScript : MonoBehaviour {
    // Hey guys,
    // if you reached this, remember to look at "Project Settins -> Time" as well

    [SerializeField] KeyCode timeKey;
    [SerializeField] float slowTimeScale = .1f; // 10%

    // remember: FixedDeltaTime is by default set at .02. (Fixed Timestamp
    // That means iterate 50 times in each second
    float fixedDeltaTime;

    bool slowMode = false;

    private void Start() {
        fixedDeltaTime = Time.fixedDeltaTime;
    }

    void Update() {
        if (Input.GetKeyUp(timeKey)) {
            slowMode = !slowMode;

            Time.timeScale = slowMode ? slowTimeScale : 1f;
            Time.fixedDeltaTime = fixedDeltaTime * Time.timeScale;
        }
    }
}
