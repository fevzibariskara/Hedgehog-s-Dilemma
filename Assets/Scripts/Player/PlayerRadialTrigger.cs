using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerRadialTrigger : MonoBehaviour
{
    public Transform objTf;

    [Range(0f, 4f)]
    public float radius = 1f;

    void OnDrawGizmos()
    {
        GetComponent<CircleCollider2D>().radius = radius;
        Vector2 objPos = objTf.position;
        Vector2 origin = transform.position;
        Vector2 disp = objPos - origin;

        float distSq = disp.sqrMagnitude;
        bool isInside = distSq < radius * radius;

        Handles.color = isInside ? Color.green : Color.red;
        Handles.DrawWireDisc(origin, new Vector3(0, 0, 1), radius);
    }
}
