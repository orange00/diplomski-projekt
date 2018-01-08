using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionModalScript : MonoBehaviour {

	public GameObject modalPanelObject;
	public GameObject taskSolvedMark;

    public GameObject CorrectImage1;
    public GameObject CorrectImage2;
    public GameObject CorrectImage3;

    public GameObject Arrow;
    public GameObject LevelEnd;

    void OnCollisionEnter2D(Collision2D collision)
	{
		if (!taskSolvedMark.activeSelf) {
            modalPanelObject.SetActive (true);
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (CorrectImage1.activeSelf && CorrectImage2.activeSelf && CorrectImage3.activeSelf)
        {
            Arrow.SetActive(true);
            LevelEnd.SetActive(true);
        }
    }
    void OnCollisionExit2D(Collision2D collision)
	{
        modalPanelObject.SetActive(false);
        
    }
}
