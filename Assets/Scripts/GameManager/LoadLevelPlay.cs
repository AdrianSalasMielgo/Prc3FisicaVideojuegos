using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadLevelPlay : MonoBehaviour
{
    public string LevelToLoad; //En esta variable indicarewmos (desde el editor)el nombre del nivel a cargar
    public GameObject mainMenuCanvas;

    public void loadLevel()
    {
        
        //Carga el nivel que contiene la variable publica-
        mainMenuCanvas.SetActive(false);

        Cursor.lockState = CursorLockMode.Locked;
    }
}
