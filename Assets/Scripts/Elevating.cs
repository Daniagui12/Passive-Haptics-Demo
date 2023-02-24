using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Experimental.UI;
using Microsoft.MixedReality.Toolkit.UI;

public class Elevating : MonoBehaviour
{
    public PinchSlider stepSlider2;
    private float scale2;

    // Update is called once per frame
    void Update()
    {
        if (stepSlider2 != null)
        {
            scale2 = stepSlider2.SliderValue;
        }
        transform.localPosition = new Vector3(0.162f, -0.566f+scale2, 1.654f); 
    }
}

