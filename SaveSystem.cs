using UnityEngine;
using System.IO;
// creado Por Cristopher Faundez, uso libre.
public static class SaveSystem
{
    // ir a la ruta de guardado= %APPDATA%\..\LocalLow
    public static void NewGame()
    {
        File.WriteAllText(Application.persistentDataPath + "data.txt",
            JsonUtility.ToJson(GameManager.instance.saveGame));
            Debug.Log("PartidaCreada");
    }
    public  static void LoadGame()
    {
        if (File.Exists(Application.persistentDataPath + "data.txt"))
        {
                JsonUtility.FromJsonOverwrite
                (File.ReadAllText(Application.persistentDataPath + "data.txt"),
                GameManager.instance.saveGame);
            Debug.Log("partida cargada");
        }
        else
        {
            Debug.Log("no hay partida guardada creada");
        }
    }
    public static void SaveCurrentGame()
    {
        File.WriteAllText(Application.persistentDataPath + "data.txt", JsonUtility.ToJson(GameManager.instance.saveGame));
        Debug.Log("partida guaradada");
    }

}

