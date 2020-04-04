using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsePlayerColor : MonoBehaviour
{
    public Player playerSetings;

    private void Start()
    {          
        gameObject.name = playerSetings.name;
        gameObject.GetComponent<Renderer>().material.color = playerSetings.colorPlayer;
    }
}
