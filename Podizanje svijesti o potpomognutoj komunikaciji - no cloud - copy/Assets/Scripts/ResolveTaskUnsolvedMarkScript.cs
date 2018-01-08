using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResolveTaskUnsolvedMarkScript : MonoBehaviour {
	public GameObject taskUnsolvedMark;
	public GameObject taskSolvedMark;

	/**
	 *  Resolves NPC task unsolved mark (eg., question mark, or glowing TV) 
	 * 	into task solved mark (eg., check mark).
	 * */
	public void resolveTaskUnsolvedMark() {
		taskUnsolvedMark.SetActive (false);
		taskSolvedMark.SetActive (true);
	}
}
