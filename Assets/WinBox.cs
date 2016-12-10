using UnityEngine;
using System.Collections;

public class WinBox : MonoBehaviour
{ 
    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("Sphere").SendMessage("Finished");
    }
}
