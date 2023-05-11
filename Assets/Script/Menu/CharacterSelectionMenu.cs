using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelectionMenu : MonoBehaviour
{
    public GameObject[] playerObjects;
    public int selectedCharacter = 0;
    
    public string gameScene = "Character Selection Scene";

    private string selectedCharacterDataName = "SelectedCharacter";
    // Start is called before the first frame update
    GameData gameData = new GameData();
    GameRepository gameRepository = new GameRepository();
    void Start()
    {
        gameData = gameRepository.GetSavedData();
        HideAllCharacters();

        selectedCharacter = PlayerPrefs.GetInt(selectedCharacterDataName, 0);

        playerObjects[selectedCharacter].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void HideAllCharacters()
    {
        foreach (GameObject g in playerObjects)
        {
            g.SetActive(false);
        }
    }

    public void NextCharacter()
    {
        playerObjects[selectedCharacter].SetActive(false);
        selectedCharacter++;
        if (selectedCharacter >= playerObjects.Length)
        {
            selectedCharacter = 0;
        }
        playerObjects[selectedCharacter].SetActive(true);
    }

    public void PreviusCharacter()
    {
        playerObjects[selectedCharacter].SetActive(false);
        selectedCharacter--;
        if (selectedCharacter < 0)
        {
            selectedCharacter = playerObjects.Length - 1;
        }
        playerObjects[selectedCharacter].SetActive(true);
    }

    public void StartGame()
    {
        PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
        SceneManager.LoadScene("Escena");
    }
    public void StartGame1()
    {
        if (gameData.Muerte==5)
        {
            Debug.Log("Entro condicion de 5");
            PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
            SceneManager.LoadScene("Escena");
        }
        
    }
    public void StartGame2()
    {
        if (gameData.Muerte==10) {
            Debug.Log("Entro condicion de 10");
            PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
            SceneManager.LoadScene("Escena");
        }
    }
}
