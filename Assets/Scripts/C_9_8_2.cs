using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class C_9_8_2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private ToggleGroup toggleGroup;

    private void Awake()
    {
        toggleGroup = GetComponent<ToggleGroup>();
  
    }

    public void OnPressToggle()
    {
        Toggle select = null;
        foreach(Toggle item in toggleGroup.ActiveToggles())
        {
            select = item;
            break;
        }
        Debug.Log("choose is " + select.transform.FindChild("Label").GetComponent<Text>().text);
    }
}
