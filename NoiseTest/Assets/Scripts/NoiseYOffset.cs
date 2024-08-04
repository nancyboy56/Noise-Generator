using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoiseYOffset : MonoBehaviour
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
        float x = material.GetVector("_NoiseOffset").x;
        material.SetVector("_NoiseOffset", new Vector2(x, sliderObject.value));

    }
}
