using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update

   
    public TextMeshProUGUI won;
    public TextMeshProUGUI lost;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    var Array = GameObject.FindGameObjectsWithTag("Enemy");// set the array to hold all GameObjects with the specified tag

    // check if there are any GameObjects (with the specified tag) spawned
    if ( Array.Length == 0 )
    {
        lost.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
    
    if ( FindObjectOfType<AIPlayer>().health < 1 )
    {
        won.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
    
    }
}


