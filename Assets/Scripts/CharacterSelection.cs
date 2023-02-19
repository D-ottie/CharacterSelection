using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CharacterSelection : MonoBehaviour
{
    public Character[] characters;
    private List<GameObject> characterList;
    public int m_selectedCharacter = 0;
    public Transform characterDisplayPoint;
    public TextMeshProUGUI playerInfo;

    void Start()
    {
        characterList = new List<GameObject>();
        foreach (var character in characters)
        {
            GameObject player = Instantiate(character.playerCharacter, characterDisplayPoint.position, characterDisplayPoint.transform.rotation);
            player.SetActive(false);
            characterList.Add(player);
        }
        characterList[m_selectedCharacter].SetActive(true);
        ShowPlayerInfo();
    }

    public void LoadNextCharacter()
    {
        characterList[m_selectedCharacter].SetActive(false);
        m_selectedCharacter = (m_selectedCharacter + 1) % characters.Length;
        characterList[m_selectedCharacter].SetActive(true);

        ShowPlayerInfo();
    }

    public void LoadPreviousCharacter()
    {
        characterList[m_selectedCharacter].SetActive(false);
        m_selectedCharacter--;
        if(m_selectedCharacter < 0)
        {
            m_selectedCharacter += characters.Length;
        }
        characterList[m_selectedCharacter].SetActive(true);
        ShowPlayerInfo();
    }

    private void ShowPlayerInfo()
    {
        playerInfo.text = "NAME : "+characters[m_selectedCharacter].name +
                        "\nSPEED : " +characters[m_selectedCharacter].speed +
                        "\nPOWER : " +characters[m_selectedCharacter].power +
                        "\nCOORDINATION : " +characters[m_selectedCharacter].coordination +
                        "\nMAGIC : " +characters[m_selectedCharacter].magic +
                        "\nAGILITY : " +characters[m_selectedCharacter].agility +
                        "\nFITNESS : " +characters[m_selectedCharacter].fitness ;
    }
    public void StartGame()
    {
        PlayerPrefs.SetInt("Selected Character", m_selectedCharacter);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1 , LoadSceneMode.Single);
    }
}
