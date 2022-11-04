using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public SaveGame saveGame;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else Destroy(gameObject);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SaveSystem.SaveCurrentGame();
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            SaveSystem.NewGame();
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            SaveSystem.LoadGame();
        }
    }
}
