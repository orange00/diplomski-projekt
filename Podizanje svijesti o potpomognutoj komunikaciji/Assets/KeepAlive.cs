using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KeepAlive : MonoBehaviour {

	private bool sfx = true;
	private bool instructions = true;

	private float scaleVolumeValue;

	private float maxVolume = 0.3f;

	private AudioSource audioSource;

	private bool changedSettings = false;

	private static KeepAlive instance = null;

	private Slider volumeSlider;
	private Toggle sfxToggle;
	private Toggle instructionsToggle;

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
		ChangedSettings = true;
		ScaleVolumeValue = scaleVolume;
		audioSource.volume = maxVolume * scaleVolume;
	}

	public void ChangeSFX() {
		ChangedSettings = true;
		sfx = !sfx;
	}

	public void ChangeInstructions() {
		ChangedSettings = true;
		instructions = !instructions;
	}

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
		get {
			return Instance;
		}
	}

	public float ScaleVolumeValue {
		get {
			return scaleVolumeValue;
		}

		set {
			scaleVolumeValue = value;
		}
	}

	public bool ChangedSettings {
		get {
			return changedSettings;
		}

		set {
			changedSettings = value;
		}
	}
}
