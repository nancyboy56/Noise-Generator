using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoiseScale : MonoBehaviour
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
        material.SetFloat("_NoiseScale", sliderObject.value);

    }
}
