using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReconfigureSettings : MonoBehaviour {

    private Toggle sfxEnabled;
    private Toggle instructionsEnabled;
    private Slider volumeValue;

    private GameObject audioManager;

	// Use this for initialization
	void Start () {
        volumeValue = GameObject.Find("Slider").GetComponent<Slider>();
        instructionsEnabled = GameObject.Find("InstructionsToggle").GetComponent<Toggle>();
        sfxEnabled = GameObject.Find("SfxToggle").GetComponent<Toggle>();

        

        audioManager = GameObject.Find("AudioManager");
        if (audioManager.GetComponent<KeepAlive>().ChangedSettings) {
            volumeValue.value = audioManager.GetComponent<KeepAlive>().ScaleVolumeValue;
            instructionsEnabled.isOn = audioManager.GetComponent<KeepAlive>().Instructions;
            sfxEnabled.isOn = audioManager.GetComponent<KeepAlive>().Sfx;
        }
        volumeValue.onValueChanged.AddListener(delegate { ChangeVolume(); });
        instructionsEnabled.onValueChanged.AddListener(delegate { ChangeInstructions(); });
        sfxEnabled.onValueChanged.AddListener(delegate { ChangeSFX(); });
    }
    public void ChangeVolume() {
        audioManager.GetComponent<KeepAlive>().ChangeVolume(volumeValue.value);
    }

    public void ChangeSFX() {
        audioManager.GetComponent<KeepAlive>().ChangeSFX();
    }

    public void ChangeInstructions() {
        audioManager.GetComponent<KeepAlive>().ChangeInstructions();
    }

}
