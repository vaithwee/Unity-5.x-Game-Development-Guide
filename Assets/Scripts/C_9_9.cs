using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class C_9_9 : MonoBehaviour {

    public Text volume;

    public Slider slider;

    float startVolumn = 0.5f;

	// Use this for initialization
	void Start () {
        volume.text = startVolumn.ToString();
        slider.value = startVolumn;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnPressSlider()
    {
        volume.text = slider.value.ToString("f2");
    }
}
