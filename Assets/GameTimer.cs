using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameTimer : MonoBehaviour {
    public Text TimerText;
    private float startTime;
    private bool finished = false;
	// Use this for initialization
	void Start () {
        startTime = Time.time;

    }
	
	// Update is called once per frame
	void Update () {
        if (finished)
            return;
        float t = Time.time - startTime;
        string minutes = ((int) t / 60).ToString();
        string seconds = (t % 60).ToString("f2");
        TimerText.text = minutes + ":" + seconds;

	}
    public void Finished()
    {
        finished = true;
        TimerText.color = Color.yellow;
        
    }

}
