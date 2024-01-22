using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialg_MeshRenderer : MonoBehaviour
{
    public MeshRenderer DialgMesh;


    void OnClick()
    {
        DialgMesh.enabled = false;
    }

}
