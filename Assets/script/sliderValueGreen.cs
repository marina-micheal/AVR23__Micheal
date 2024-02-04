using MixedReality.Toolkit.UX;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sliderValueGreen : MonoBehaviour
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

        newObjectColor.g = eventData.NewValue;

        objectMaterial.SetColor("_BaseColor", newObjectColor);
    }

}
