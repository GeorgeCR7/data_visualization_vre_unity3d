using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCounter : MonoBehaviour {

    Rect fpsRect;
    GUIStyle style;

    float fps;

	// Use this for initialization
	void Start () {

        fpsRect = new Rect(100,100,400,100);
        style = new GUIStyle();
        style.fontSize = 36;

        StartCoroutine(RecalculateFPS());
	}
	
	private IEnumerator RecalculateFPS()
    {
        while (true)
        {
            fps = 1 / Time.deltaTime;
            yield return new WaitForSeconds(1);
        }
    }

    void OnGUI()
    {
        GUI.Label(fpsRect,"FPS: "+ fps,style);
    }
}
