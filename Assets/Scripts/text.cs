using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text : MonoBehaviour
{
    public Color[] Colors;
    public static int count;
    Text scoreText;
    

    void Start()
    {
        scoreText = GetComponent<Text>();
        count = 0;
      
    }
    void Update()
    {
       
        scoreText.text = "Score:" + count;

    }
    
}
