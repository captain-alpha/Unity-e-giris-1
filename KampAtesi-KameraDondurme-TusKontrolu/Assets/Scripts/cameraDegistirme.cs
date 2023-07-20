using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraDegistirme : MonoBehaviour
{
    public Camera camera2;
    public Camera camera1;
    public bool c1mi;
    // Start is called before the first frame update
    void Start()
    {
        camera1 = Camera.main;
        camera2 = GameObject.Find("camera2").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            camera2.enabled = c1mi;
            camera1.enabled = !c1mi;
            c1mi = !c1mi;
        }

        if (c1mi)
        {
            camera1.enabled = true;
            camera2.enabled = false;
        }

        else
        {
            camera1.enabled = false;
            camera2.enabled = true;
        }
    }
}
