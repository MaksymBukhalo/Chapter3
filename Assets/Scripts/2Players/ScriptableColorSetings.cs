using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayersColor", menuName = "listOfPlayerColors/List")]

public class ScriptableColorSetings : ScriptableObject
{
    public string appName = "New name";
    public string appVersion = "0.0.0";
    public List <Player> listOfPlayerColors;  
}
