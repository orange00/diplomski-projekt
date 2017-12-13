using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSolvedScript : MonoBehaviour {
	public GameObject correctAnswerHandler;

	/**
	 * Performs closing tasks, whhen a whole obstacle is solved, 
	 * (eg., closes modal, resolves question mark or glowing TV,...)
	 * */
	public void obstacleSolved ()
	{
		correctAnswerHandler.GetComponent<ResolveTaskUnsolvedMarkScript> ().resolveTaskUnsolvedMark ();
		correctAnswerHandler.GetComponent<CloseModalScript> ().closeModal ();
	}
}
