using UnityEngine;
using System.Collections;

public class GoalSpin : MonoBehaviour {
    public int SpinRate;
    private bool positron;
	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update() {
        // ...also rotate around the World's Y axis
        transform.Rotate(0, SpinRate, 0, Space.World);
       

    }
}
