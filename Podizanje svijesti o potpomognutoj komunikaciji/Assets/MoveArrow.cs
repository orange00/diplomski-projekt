using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveArrow : MonoBehaviour {

    IEnumerator Start() {
        Vector3 pointA = transform.position;
        Vector3 pointB = new Vector3(pointA.x, pointA.y + 0.85f, pointA.z);
        while (true) {
            yield return StartCoroutine(MoveObject(transform, pointA, pointB, 1.05f));
            yield return StartCoroutine(MoveObject(transform, pointB, pointA, 1.05f));
        }
    }

    IEnumerator MoveObject(Transform thisTransform, Vector3 startPos, Vector3 endPos, float time) {
        var i = 0.0f;
        var rate = 1.0f / time;
        while (i < 1.0f) {
            i += Time.deltaTime * rate;
            thisTransform.position = Vector3.Lerp(startPos, endPos, i);
            yield return null;
        }
    }
}
