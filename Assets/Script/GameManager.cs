using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor.SearchService;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    GameData gameData = new GameData();
    GameRepository gameRepository;
    Text scoreText;
    Text vidasText;
    Text MonedasText;
    Text MuerteText;
    void Start()
    {
        
        gameRepository = GetComponent<GameRepository>();
        //borrar data
        //gameRepository.SaveData(gameData);
        scoreText = GameObject.Find("/Canvas/BalasPuntaje").GetComponent<Text>();
        vidasText = GameObject.Find("/Canvas/VidasPersonaje").GetComponent<Text>();
        MonedasText = GameObject.Find("/Canvas/NumeroMonedas").GetComponent<Text>();
        MuerteText = GameObject.Find("/Canvas/MuerteText").GetComponent<Text>();
        gameData = gameRepository.GetSavedData();

        LoadScreenTexts();
    }
    void LoadScreenTexts()
    {
        scoreText.text = $"Puntaje: {gameData.Score}";
        vidasText.text = $"Vidas: {gameData.Vidas}";
        MonedasText.text = $"Llaves: {gameData.Monedas}";
        MuerteText.text = $"Puntaje: {gameData.Muerte}";
    }

    public void GanarPunto()
    {
        gameData.Score++;
        gameRepository.SaveData(gameData);
        LoadScreenTexts();
    }
    public void GanarMoneda()
    {
        gameData.Monedas ++;
        gameRepository.SaveData(gameData);
        LoadScreenTexts();
    }
    public void MuerteZombie() { 
        gameData.Muerte ++;
        gameRepository.SaveData(gameData);
        LoadScreenTexts();
    }
    public void CambiarEscena() {
        int cont = gameData.Monedas;
        if (SceneManager.GetActiveScene().name=="Escena")
        {
            if (cont == 3)
            {
                Debug.Log("valor " + cont);
                SceneManager.LoadScene("Escena2");
            }
        }
        if (SceneManager.GetActiveScene().name == "Escena2")
        {
            if (cont == 6)
            {
                Debug.Log("valor " + cont);
                SceneManager.LoadScene("Escena3");
            }
        }

    }
    public List<string> GetSkills()
    {
        return gameData.Skills;
    }
}
