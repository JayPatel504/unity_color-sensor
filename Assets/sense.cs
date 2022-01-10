using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class sense : MonoBehaviour
{
    public TMP_Text sliderC,red,green,yellow,magenta,blue,cyan,black,white,gray;
    public Slider slide;
    private Dictionary<Color,TMP_Text> My_dict = new Dictionary<Color,TMP_Text>();         
    private string colour;
    // Start is called before the first frame update
    void Start(){
    }

    // Update is called once per frame
    void Update(){
        if (slide.value == 2){
            My_dict = new Dictionary<Color,TMP_Text>(){
                        {Color.red,red},
                        {Color.green,green},
                        {Color.blue,blue}
                    };
            sliderC.color = Color.red;
            sliderC.text = "RGB";
        }
        if (slide.value == 0){
            My_dict = new Dictionary<Color,TMP_Text>(){
                        {Color.cyan,cyan},                        
                        {Color.magenta,magenta},
                        {Color.yellow,yellow}                        
                    };
            sliderC.color = Color.cyan;
            sliderC.text = "CMY";
        }
        if (slide.value == 1){
            My_dict = new Dictionary<Color,TMP_Text>(){
                        {Color.black,black},
                        {Color.white,white},
                        {Color.gray,gray}
                    };
            sliderC.color = Color.gray;
            sliderC.text = "Gray";
        }        
    }

    private void OnTriggerEnter(Collider other){
        var col = other.gameObject.GetComponent<Renderer>().material.GetColor("_Color");
        foreach(var item in My_dict){
            if(col == item.Key){
                int q = Int32.Parse(item.Value.text)+1;
                item.Value.text = q.ToString();
                // item.Value++;
                Debug.Log(colour);
            }
        }
    }

}
