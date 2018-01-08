using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public Sprite soundOff, soundOn;
	public AudioSource music;
	public GameObject girlImage, boyImage;
	public GameObject playButton, titleButton;
	public float speed, scaleDuration;
	public GameObject charSelectFirst, charSelectSecond;

	private bool moveCharacters = false;
	private Button girlButton;
	private Button boyButton;

	private void Start() {
		music.Play();
		girlButton = girlImage.GetComponent<Button>();
		boyButton = boyImage.GetComponent<Button>();
	}

	public void ChangeScene(string name) {
		SceneManager.LoadScene(name);
	}

	private void Update() {
		if (moveCharacters) {
			float step = speed * Time.deltaTime;
			girlImage.transform.position = Vector3.MoveTowards(girlImage.transform.position, charSelectFirst.transform.position, step);
			boyImage.transform.position = Vector3.MoveTowards(boyImage.transform.position, charSelectSecond.transform.position, step);
			StartCoroutine(ScaleObject());
		}

		if (girlImage.transform.position.Equals(charSelectFirst.transform.position)) {
			moveCharacters = false;
			titleButton.SetActive(true);
			girlButton.interactable = true;
			boyButton.interactable = true;
		}
	}

	public void ModifyScene() {
		playButton.SetActive(false);
		moveCharacters = true;
	}

	IEnumerator ScaleObject() {
		Vector3 targetScale = new Vector3(1.5f, 1.5f, 1f);     // scale of the object at the end of the animation

		for (float t = 0; t < 1; t += Time.deltaTime / scaleDuration) {
			girlImage.transform.localScale = Vector3.Lerp(girlImage.transform.localScale, targetScale, t);
			boyImage.transform.localScale = Vector3.Lerp(boyImage.transform.localScale, targetScale, t);
			yield return null;
		}
	}
}
