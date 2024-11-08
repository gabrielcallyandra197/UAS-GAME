using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    

    public void PlayAgain()
    {
        PlayerHealth.instance.ResetScore();
        SceneManager.LoadScene("Gameplay 1");
       
    }

    public void MainMenu()
    {
       
        SceneManager.LoadScene("MainMenu");  
    }
}
