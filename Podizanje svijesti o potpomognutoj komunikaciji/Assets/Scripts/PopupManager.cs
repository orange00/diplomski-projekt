using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PopupManager : MonoBehaviour {

    // Canvas to enable/disable
    public Canvas taskCanvas;

	// We put various graphic objects (particle systems, images etc.) in these variables so we can enable/disable them.
	public GameObject currentVisualGameObject;
	public GameObject nextVisualGameObject;

    // Game objects to interact with on level end
    public GameObject door;
    public GameObject arrow;
    public GameObject levelEndCollider;

	//Canvas elements
	public Image leftAnswer;
	public Image rightAnswer;
	public TextMeshProUGUI titleText;
	public GameObject wrongAnswerLeft;
    public GameObject wrongAnswerRight;
    public GameObject correctAnswerLeft;
    public GameObject correctAnswerRight;

    // Background image - so we can reduce the alpha on it when the popup shows up.
    public GameObject background;
	public GameObject mask;

    // Task speeches
    public GameObject femaleSpeech;
    public GameObject maleSpeech;

	// Elements with which we can fill the canvas
	public Sprite leftImage;
	public Sprite rightImage;


    // Bool variable to show which answer is correct - false = left, true = right
    public bool correct;
    public string objectName;

    // Sprites of game objects
    private SpriteRenderer backgroundSprite;
    private SpriteRenderer maskSprite;

    private bool solved = false;

    private TextMeshProUGUI colliderText;
    private string thisName;
    private bool correctAnswerForUse;


	// Use this for initialization
	void Start () {
        
        taskCanvas.enabled = false;
        thisName = name;
        backgroundSprite = background.GetComponent<SpriteRenderer>();
        maskSprite = mask.GetComponent<SpriteRenderer>();
        

        leftAnswer.sprite = leftImage;
        rightAnswer.sprite = rightImage;

        GameObject characterSelected = GameObject.Find("CharacterSelected");
        Debug.Log(characterSelected.GetComponent<CharacterSelected>().characterName);
        if (characterSelected.GetComponent<CharacterSelected>().characterName == "Female") {
            colliderText = femaleSpeech.GetComponent<TextMeshProUGUI>();
        } else {
            colliderText = maleSpeech.GetComponent<TextMeshProUGUI>();
        }
        
        titleText.text = colliderText.text;
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        correctAnswerForUse = correct;
        Debug.Log(correct);
        Debug.Log(correctAnswerForUse);

        if (!solved && thisName == objectName) {
            taskCanvas.enabled = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision) {
        taskCanvas.enabled = false;
    }

    public void ClickedLeftAnswer() {
        //Debug.Log(correctAnswerForUse);
        if (correctAnswerForUse) {
            wrongAnswerLeft.SetActive(true);
        } else {
            StartCoroutine(ShowCorrectAnswer(correctAnswerLeft));
        }
    }

    public void ClickedRightAnswer() {
        //Debug.Log(correctAnswerForUse);
        if (correctAnswerForUse) {
            StartCoroutine(ShowCorrectAnswer(correctAnswerRight));
        } else {
            wrongAnswerRight.SetActive(true);
        }
    }

    
    public IEnumerator ShowCorrectAnswer(GameObject answer) {
        answer.SetActive(true);
        yield return new WaitForSeconds(1f);
        answer.SetActive(false);
        solved = true;
        if (wrongAnswerRight.activeSelf) {
            wrongAnswerRight.SetActive(false);
        } else if (wrongAnswerLeft.activeSelf) {
            wrongAnswerLeft.SetActive(false);
        }
        taskCanvas.enabled = false;
        currentVisualGameObject.SetActive(false);
        if(nextVisualGameObject.name == "LevelEnd") {
            door.SetActive(false);
            arrow.SetActive(true);
            levelEndCollider.SetActive(true);
        } else {
            nextVisualGameObject.SetActive(true);
        }
    }

}
