using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public int Vidas;
    public int Score;
    public int Monedas;
    public int Muerte;
    public List<string> Skills;
    public GameData()
    {
        Score = 5;
        Vidas = 2;
        Monedas = 0;
        Muerte = 0;
        Skills = new List<string>();
    }
}
