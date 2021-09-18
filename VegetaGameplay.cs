using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[System.Serializable]
public class VegetaGameplay : MonoBehaviour
{
    // Thank you for downloading my tutorial have fun coding
    // Text for a rage meter and Winning State

    [SerializeField] Text RageText;
    public string RageMeter;
    public float Rage = 0;
    public GameObject Stage1;
    public GameObject Win;
    public int Stage = 0;

// Start is called before the first frame update
    void Start()
    {
        RageText.text = "Rage Meter: " + Rage.ToString();
        Debug.Log("Serialized Text and Float (Float could have also been and Integer");
    }

    // Update is called once per frame
    void Update()
    {

        PlayerPrefs.GetFloat("Rage", Rage);
        RageText.text = "Rage Meter: " + Rage.ToString();
        if (Rage <= 999)
        {
            Win.SetActive(false);
            Debug.Log("You have not won yet");
        }
        if (Rage >= 1000)
        {
            Win.SetActive(true);
            Stage1.SetActive(false);
            Debug.Log("You have won!!!");
        }
    }
     
    //Add to Stage
    public void StageClear()
    {
        Stage += 1;
    }

    // Add to Rage
    public void Ragingg()
    {

        Rage += 50;
        Debug.Log("You Raged");
        PlayerPrefs.SetFloat("Rage", Rage);
    }

    public void Save()
    {
        PlayerPrefs.SetFloat("Rage",Rage);
    }

    public void Delete()
    {
        PlayerPrefs.DeleteAll();
    }
    public void WinScreen()
    {
        SceneManager.LoadScene("Win");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
