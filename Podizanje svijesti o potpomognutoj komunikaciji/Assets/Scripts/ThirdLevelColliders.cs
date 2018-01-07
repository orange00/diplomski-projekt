using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdLevelColliders : MonoBehaviour
{

    public GameObject modalPanelObject;
    public GameObject taskSolvedMark;
    BoxCollider2D m_Collider;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!taskSolvedMark.activeSelf)
        {
            modalPanelObject.SetActive(true);
        }
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (taskSolvedMark.activeSelf)
        {
            m_Collider = GetComponent<BoxCollider2D>();
            m_Collider.enabled = !m_Collider.enabled;
            //Debug.Log("Collider.enabled = " + m_Collider.enabled);
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        modalPanelObject.SetActive(false);
    }
}
