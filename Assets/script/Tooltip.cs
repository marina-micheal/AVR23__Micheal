using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent (typeof(LineRenderer))]
public class Tooltip : MonoBehaviour
{
    public Transform start;
    public Transform end;

    [Tooltip("Draw the line with an offset")]
    public Vector3 offset =new Vector3 (0,-0.05f,0);

    private LineRenderer lineRenderer;


    private void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }


    // Update is called once per frame
    void Update()
    {
        lineRenderer.SetPosition(0,start.position+offset);
        lineRenderer.SetPosition(1,end.position );

        //Rotate label that will always face the user
        this.transform.LookAt(Camera.main.transform);
    }
}
