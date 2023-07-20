using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textScript : MonoBehaviour
{
    GameObject plane;
    Text txt;
    GameObject g;
    private Canvas cn;
    // Start is called before the first frame update
    void Start()
    {
        plane = GameObject.Find("Plane");
        cn = GetComponent<Canvas>();
        txt = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
          //  Instantiate(plane, transform.position, transform.rotation);
            for (float i = 255; i >= 0; i -= Time.time)
            {
                Debug.Log(i);
                txt.color = new Color(1, 1, 1, i);
            }
        }

        
    }
    //void ontriggerenter(Collision other)
    //{
    //    if (other.name== "emptygameobject")
    //    {
    //        int score;
    //        score++;
    //    }
    //}
}
