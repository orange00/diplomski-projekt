using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleTaskModalScript : MonoBehaviour {
	public GameObject currentTask;
	public GameObject nextTask;

	public GameObject correctAnswerHandler;

	public GameObject correctAnswerAlert;

	/**
	 * Goes to next task in the same modal, 
	 * or finishes the last task, after 
	 * the user chooses the correct answer.
	 * 
	 * */
	public void NextTaskOrFinish() {
		if (nextTask != null) {
			StartCoroutine("NextTask");
		} else {
			StartCoroutine("FinishObstacle");
		}
	}

	public IEnumerator NextTask ()
	{
		yield return ShowcaseCorrectAnswerAlert();
		currentTask.SetActive (false);
		nextTask.SetActive (true);
	}

	public IEnumerator FinishObstacle ()
	{
		yield return ShowcaseCorrectAnswerAlert();
		correctAnswerHandler.GetComponent<ObstacleSolvedScript> ().obstacleSolved ();
	}

	public IEnumerator ShowcaseCorrectAnswerAlert ()
	{
		correctAnswerAlert.SetActive (true);
		yield return new WaitForSeconds(1.2f);
		correctAnswerAlert.SetActive (false);
	}


}
