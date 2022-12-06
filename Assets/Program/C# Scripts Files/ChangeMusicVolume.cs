using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeMusicVolume : MonoBehaviour {

    public Slider Volume;
    public GameObject sliderVolume;
    public GameObject volumeLabel;
    public GameObject valueVolumeText;
    public AudioSource myMusic;
	
	void Update () {

        myMusic.volume = Volume.value;
        sliderVolume.SetActive(false);
        volumeLabel.SetActive(false);
        valueVolumeText.SetActive(false);

        if (myMusic.isPlaying)
        {
            sliderVolume.SetActive(true);
            volumeLabel.SetActive(true);
            valueVolumeText.SetActive(true);
        }

	}
}
