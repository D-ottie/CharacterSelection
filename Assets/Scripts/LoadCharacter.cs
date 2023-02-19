using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoadCharacter : MonoBehaviour
{

    public GameObject[] characterPrefabs;
    public Transform spawnPos;

    // Start is called before the first frame update
    void Start()
    {
        int PREFS_SELECTED_CHARACTER = PlayerPrefs.GetInt("selectedCharacter");
        GameObject player = Instantiate(characterPrefabs[PREFS_SELECTED_CHARACTER], spawnPos.position, spawnPos.rotation);

    }

}
