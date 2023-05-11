using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PuntajeController : MonoBehaviour
{
    // Start is called before the first frame update
    GameData gameData = new GameData();
    GameRepository gameRepository = new GameRepository();
    Text MuerteText;
    void Start()
    {
        MuerteText = GameObject.Find("/Canvas/Puntaje").GetComponent<Text>();
        gameData = gameRepository.GetSavedData();
    }

    // Update is called once per frame
    void Update()
    {
        MuerteText.text = $"Puntaje: {gameData.Muerte}";
    }
}
