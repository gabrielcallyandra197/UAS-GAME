using UnityEngine;
using UnityEngine.SceneManagement;  
public class GameWin : MonoBehaviour
{
    public string winSceneName = "YouWin"; 

    public void PlayerWins()
    {
        
        SceneManager.LoadScene(winSceneName);
    }

    
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Player"))
        {
            PlayerWins();
        }
    }
}
