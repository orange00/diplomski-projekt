using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdLevelColliders : MonoBehaviour
{

    public GameObject modalPanelObject;
    public GameObject taskSolvedMark;
    public GameObject endPosition;
    public bool shouldFlip;
    public float time = 1f;
    BoxCollider2D m_Collider;

    private SpriteRenderer spriteRenderer;

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
            taskSolvedMark.SetActive(false);
            m_Collider = GetComponent<BoxCollider2D>();
            m_Collider.enabled = !m_Collider.enabled;
            endPosition.transform.position = new Vector3(endPosition.transform.position.x, endPosition.transform.position.y, transform.position.z);
            if (shouldFlip) {
                spriteRenderer = GetComponent<SpriteRenderer>();
                spriteRenderer.flipX = true;
            }
            StartCoroutine(MoveObject(transform, transform.position, endPosition.transform.position, time));
            //Debug.Log("Collider.enabled = " + m_Collider.enabled);
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        modalPanelObject.SetActive(false);
    }

    IEnumerator MoveObject(Transform thisTransform, Vector3 startPos, Vector3 endPos, float time) {
        var i = 0.0f;
        var rate = 1.0f / time;
        while (i < 1.0f) {
            i += Time.deltaTime * rate;
            thisTransform.position = Vector3.Lerp(startPos, endPos, i);
            yield return null;
        }
        if(thisTransform.position == endPos) {
            gameObject.SetActive(false);
        }
    }
}
