using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsePlayerColor : MonoBehaviour
{
    public ScriptableColorSetings colorSetings;
    public int numberPlayer;

    void Update()
    {
        GetComponent<Renderer>().material.color = colorSetings.listOfPlayerColors[numberPlayer-1].colorPlayer;
    }
}
