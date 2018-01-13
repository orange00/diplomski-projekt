using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionModalScript : MonoBehaviour {

	public GameObject modalPanelObject;
	public GameObject taskSolvedMark;

<<<<<<< HEAD
    public GameObject CorrectImage1;
    public GameObject CorrectImage2;
    public GameObject CorrectImage3;

    public GameObject Arrow;
    public GameObject LevelEnd;

=======
>>>>>>> 767700e7eac12644faab7151b49780d0cdb55b34
    void OnCollisionEnter2D(Collision2D collision)
	{
		if (!taskSolvedMark.activeSelf) {
            modalPanelObject.SetActive (true);
        }
<<<<<<< HEAD
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
        
=======
	}

    void OnCollisionExit2D(Collision2D collision)
	{
        modalPanelObject.SetActive(false);
>>>>>>> 767700e7eac12644faab7151b49780d0cdb55b34
    }
}
