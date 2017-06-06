using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_3_5_1 : MonoBehaviour
{

    void OnGUI()
    {
        if (GUILayout.Button("Create Cube", GUILayout.Height(50)))
        {
            GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
            obj.AddComponent<Rigidbody>();
            obj.GetComponent<Renderer>().material.color = Color.red;
            obj.name = "Cube";
            obj.transform.position = new Vector3(0, 5f, 0);
        }

        if (GUILayout.Button("Create Sphere", GUILayout.Height(50)))
        {
            GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            obj.AddComponent<Rigidbody>();
            obj.GetComponent<Renderer>().material.color = Color.green;
            obj.name = "Sphere";
            obj.transform.position = new Vector3(0, 5f, 0);
        }
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
