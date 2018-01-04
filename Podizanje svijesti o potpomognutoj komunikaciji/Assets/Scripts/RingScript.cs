using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RingScript : MonoBehaviour {

	public int numberOfElements;
	public int currentElement = 0;
	public Element[] elements;
	public Sprite someSprite;
	public Canvas elementCanvas;
	public Image elementImage;
	public Button button;
	public TextMeshProUGUI buttonText;
	public TextMeshProUGUI detailsText;

	ParticleSystem ps;
	List<ParticleSystem.Particle> enter = new List<ParticleSystem.Particle>();

	// Use this for initialization
	void Start () {
		ps = GetComponent<ParticleSystem>();
		elements = new Element[numberOfElements];
	}

	private void OnParticleTrigger() {

		elementCanvas.enabled = true;
		elementImage.sprite = elements[currentElement].sprite;
		detailsText.text = elements[currentElement].details;
		if(currentElement == numberOfElements - 1) {
			buttonText.text = "Exit";
		} else {
			buttonText.text = "Next";
		}

		var emission = ps.emission;
		emission.enabled = false;
		
	}

	public void ChangeNumber() {
		currentElement++;
	}

}
