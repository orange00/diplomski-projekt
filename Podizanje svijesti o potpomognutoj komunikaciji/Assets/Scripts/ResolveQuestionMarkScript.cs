using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResolveQuestionMarkScript : MonoBehaviour {
	public GameObject questionMark;
	public GameObject correctMark;

	/**
	 *  Changes the question mark into the correct mark.
	 * */
	public void resolveQuestionMark() {
		questionMark.SetActive (false);
		correctMark.SetActive (true);
	}
}
