using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitorNext : MonoBehaviour
{
    public string NameScene = "";
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    { 
        if (collision.tag.Equals("Player"))
        {
            if (ObjectiveManager.instance.isObjectiveCollected)
            {
                UnlockedNewLevel();
                SceneManager.LoadScene(NameScene);
            }
            else
            {
                
                Debug.Log("You must collect the objective to proceed to the next level!");
            }
        }
    }

    void UnlockedNewLevel()
    {
        if(SceneManager.GetActiveScene().buildIndex >= PlayerPrefs.GetInt("ReachedIndex"))
        {
            PlayerPrefs.SetInt("ReachedIndex", SceneManager.GetActiveScene().buildIndex + 1);
            PlayerPrefs.SetInt("UnlockedLevel", PlayerPrefs.GetInt("UnlockedLevel", 1) + 1);
            PlayerPrefs.Save();
        }
    }
}
