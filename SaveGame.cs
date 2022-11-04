using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="save",menuName ="save")]
[System.Serializable]
public class SaveGame : ScriptableObject 
{
    public int monedas=0;
    public string nombre="default"; 
}
