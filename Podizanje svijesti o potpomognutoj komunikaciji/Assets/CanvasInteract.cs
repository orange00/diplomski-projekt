using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CanvasInteract : MonoBehaviour {

    public bool canStart;

    public GameObject currentCanvas;

    public GameObject nextObject;

    public GameObject currentVisual;
    public GameObject nextVisual;

    public TextMeshProUGUI titleText;

    // Task speeches
    public GameObject femaleSpeech;
    public GameObject maleSpeech;

    // Pictures to activate
    public GameObject wrongAnswer;
    public GameObject correctAnswer;

    // Background image - so we can reduce the alpha on it when the popup shows up.
    public GameObject background;
    public GameObject mask;

    // Game objects to interact with on level end
    public GameObject door;
    public GameObject arrow;
    public GameObject levelEndCollider;

    private TextMeshProUGUI colliderText;
    private CanvasInteract nextCInteract;

    private bool solved = false;

    private void Start() {
        GameObject characterSelected = GameObject.Find("CharacterSelected");

        if (characterSelected.GetComponent<CharacterSelected>().characterName == "Female") {
            colliderText = femaleSpeech.GetComponent<TextMeshProUGUI>();
        } else {
            colliderText = maleSpeech.GetComponent<TextMeshProUGUI>();
        }

        titleText.text = colliderText.text;
        canStart = true;
        nextCInteract = nextObject.GetComponent<CanvasInteract>();
    }

    private void OnCollisionEnter2D(Collision2D collision) {

        if (!solved && canStart) {
            currentCanvas.SetActive(true);
        }
    }

    private void OnCollisionExit2D(Collision2D collision) {
        currentCanvas.SetActive(false);
    }

    public void WrongAnswer() {
        wrongAnswer.SetActive(true);
    }

    public void CorrectAnswer() {
        StartCoroutine(ShowCorrectAnswer());
    }

    public IEnumerator ShowCorrectAnswer() {
        correctAnswer.SetActive(true);
        yield return new WaitForSeconds(1f);
        correctAnswer.SetActive(false);
        solved = true;

        currentCanvas.SetActive(false);
        currentVisual.SetActive(false);

        if (nextVisual.name == "LevelEnd") {
            door.SetActive(false);
            arrow.SetActive(true);
            levelEndCollider.SetActive(true);
        } else {
            nextVisual.SetActive(true);
            nextCInteract.enabled = true;
            enabled = false;
        }
    }
}
