using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    public float time = 4.0f;
    public Text winText;
    public string text;
	// Use this for initialization
	//void Start ()
 //   {
		
	//}
	
	// Update is called once per frame
	void Update ()
    {
        time -= Time.deltaTime;

        if (time <= 0.0f)
        {
            TimerEnded();
        }

        if (time <= -4.0f)
        {
            EmptyString();
        }   
	}

    void TimerEnded()
    {
        winText.text = text;
    }

    void EmptyString()
    {
        text = null;
    }
}
