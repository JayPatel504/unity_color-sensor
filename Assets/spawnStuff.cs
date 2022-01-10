using Random=UnityEngine.Random;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class spawnStuff : MonoBehaviour
{
    private List<Color> colorList = new List<Color>(){
         Color.red,
         Color.green,
         Color.yellow,
         Color.magenta,
         Color.blue,
         Color.cyan,
         Color.black,
         Color.white,
         Color.gray
         };
    public GameObject rend;
    private Vector3 prev;
    private bool move=true;
    public float t;
    public TMP_Text distance;
    // Start is called before the first frame update
    void Start()
    {
        prev = rend.transform.position;
        float dist = Vector3.Distance(rend.transform.position, new Vector3(0,0,0));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)){
            rend.transform.position = prev;
            move=true;
        }
        if (Input.GetKeyDown(KeyCode.Space)){
            rend.GetComponent<Renderer>().material.color = colorList[Random.Range(0, colorList.Count - 1)];
        }
        if (Input.GetKeyDown(KeyCode.Keypad1)){
            rend.GetComponent<Renderer>().material.color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.Keypad2)){
            rend.GetComponent<Renderer>().material.color = Color.green;
        }
        if (Input.GetKeyDown(KeyCode.Keypad3)){
            rend.GetComponent<Renderer>().material.color = Color.blue;
        }
        if (Input.GetKeyDown(KeyCode.Keypad4)){
            rend.GetComponent<Renderer>().material.color = Color.cyan;
        }
        if (Input.GetKeyDown(KeyCode.Keypad5)){
            rend.GetComponent<Renderer>().material.color = Color.magenta;
        }
        if (Input.GetKeyDown(KeyCode.Keypad6)){
            rend.GetComponent<Renderer>().material.color = Color.yellow;
        }
        if (Input.GetKeyDown(KeyCode.Keypad7)){
            rend.GetComponent<Renderer>().material.color = Color.black;
        }
        if (Input.GetKeyDown(KeyCode.Keypad8)){
            rend.GetComponent<Renderer>().material.color = Color.white;
        }
        if (Input.GetKeyDown(KeyCode.Keypad9)){
            rend.GetComponent<Renderer>().material.color = Color.gray;
        }
        if(move && rend.transform.position!=new Vector3(0,0,0)){
            t += Time.deltaTime;
            transform.position = Vector3.Lerp(prev, new Vector3(0,0,0), t);
        }
        else{
            float dist = Vector3.Distance(prev, new Vector3(0,0,0));
            distance.text = dist.ToString("F2");
            t=0;
            move=false;
        }
    }
}
