﻿using UnityEngine;
using System.Collections;

public class WinBox : MonoBehaviour
{
    public AudioSource Music;

    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("Sphere").SendMessage("Finished");
        

    }
}
