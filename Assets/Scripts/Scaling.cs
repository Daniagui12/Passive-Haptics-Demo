using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Experimental.UI;
using Microsoft.MixedReality.Toolkit.UI;

public class Scaling : MonoBehaviour
{
    public PinchSlider stepSlider;
    public float scale = 1.0f;
    public float scaleMin = 0.1f;
    public float scaleMax = 10.0f;
    public float scaleStep = 0.1f;

    // Update is called once per frame
    void Update()
    {
        if (stepSlider != null)
        {
            scale = stepSlider.SliderValue;
        }
        transform.localScale = new Vector3(2.5f, 0.1f, scale*10.0f);    
    }
}

