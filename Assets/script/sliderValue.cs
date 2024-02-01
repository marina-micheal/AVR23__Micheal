using MixedReality.Toolkit.UX;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sliderValue : MonoBehaviour
{
    public GameObject objectToChangeColor;
    private Material objectMaterial;
    private Color newObjectColor;

    // Start is called before the first frame update
    private void Awake()
    {
        objectMaterial = objectToChangeColor.GetComponent<Renderer>().material;
        newObjectColor = objectMaterial.color;
    }
    public void ChangeMaterialColor(SliderEventData eventData)
    {
        Debug.Log(eventData.NewValue);

        newObjectColor.b = eventData.NewValue;
        objectMaterial.SetColor("_BaseColor", newObjectColor);
    }


}
