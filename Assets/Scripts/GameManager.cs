﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Si pulsa la tecla P o hace click izquierdo que empiece el juego
        if(Input.GetKeyDown(KeyCode.P) || Input.GetMouseButton(0))
        {
            // Cargo la escena de Juego
            SceneManager.LoadScene("SampleScene");
        }
    }
}
