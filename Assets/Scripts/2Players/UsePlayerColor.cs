using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsePlayerColor : MonoBehaviour
{
    public Player playerSetings;
    
    void Update()
    {
        gameObject.name = playerSetings.name;
        gameObject.GetComponent<Renderer>().material.color = playerSetings.colorPlayer;
    }
}
