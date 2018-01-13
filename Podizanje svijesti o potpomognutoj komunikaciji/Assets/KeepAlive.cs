using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeepAlive : MonoBehaviour {

    private bool sfx = true;
    private bool instructions = true;
    public Slider volumeSlider;

    private float maxVolume = 0.3f;

    private AudioSource audioSource;

    private static KeepAlive instance = null;

    public bool Sfx {
        get {
            return sfx;
        }

        set {
            sfx = value;
        }
    }

    public bool Instructions {
        get {
            return instructions;
        }

        set {
            instructions = value;
        }
    }

    public static KeepAlive Instance {
		get { return Instance; }
	}

	private void Awake() {
		if (instance != null && instance != this) {
			Destroy(this.gameObject);
			return;
		} else {
			instance = this;
		}
		DontDestroyOnLoad(this.gameObject);
	}

    private void Start() {
        audioSource = GetComponent<AudioSource>();
    }

    public void ChangeVolume(float scaleVolume) {
        volumeSlider.value = scaleVolume;
        audioSource.volume = maxVolume * scaleVolume;
    }

    public void ChangeSFX() {
        sfx = !sfx;
    }

    public void ChangeInstructions() {
        instructions = !instructions;
    }
}
