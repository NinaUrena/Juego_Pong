﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raqueta : MonoBehaviour
{
    // Velocidad
    public float velocidad = 30.0f;

    // Eje vertical
    public string eje;

    // Es llamada una vez cada fixed frame
    void FixedUpdate () {
        // Capta el valor del eje vertical de la raqueta
        float v = Input.GetAxisRaw(eje);
        // Modificar la velocidad de la raqueta
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v * velocidad);
    }

}
