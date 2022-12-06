using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowMusicVolume : MonoBehaviour {

    Text volumeValueText;
	
	public void textUpdate (float value) {

        volumeValueText = GetComponent<Text>();

        volumeValueText.text = Mathf.RoundToInt(value * 100) + "%";
		
	}
}
