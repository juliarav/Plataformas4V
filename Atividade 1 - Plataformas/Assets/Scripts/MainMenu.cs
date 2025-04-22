using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        Loader.Instance.LoadScene("Game"); 
    }
    
    public void QuitGame()
    {
        Debug.Log("Saindo do jogo...");
        Application.Quit(); 
    }
    
}



