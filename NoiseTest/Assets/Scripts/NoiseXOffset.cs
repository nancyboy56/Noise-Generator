using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoiseXOffset : MonoBehaviour
{
    public GameObject noise;
    private Slider sliderObject;

    // Start is called before the first frame update
    void Start()
    {
        sliderObject = this.GetComponent<Slider>();
        sliderObject.onValueChanged.AddListener(delegate { UpdateScale(); });

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void UpdateScale()
    {
        Material material = noise.GetComponent<Material>();
        float y = material.GetVector("_NoiseOffset").y;
        material.SetVector("_NoiseOffset", new Vector2(sliderObject.value, y));

    }
}

