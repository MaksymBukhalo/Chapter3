using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Players", menuName = "Player")]
public class Player : ScriptableColorSetings
{
    public string namePlayer;
    public Color colorPlayer;

    public Player(string namePlayer, Color colorPlayer)
    {
        this.namePlayer = namePlayer;
        this.colorPlayer = colorPlayer;

    }

}
