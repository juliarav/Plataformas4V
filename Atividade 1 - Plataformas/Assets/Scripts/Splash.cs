using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.SceneManagement;




public class Splash : MonoBehaviour
{
    void Start()
    {
      
        StartCoroutine(LoadMainMenuAfterDelay());
    }
      
    IEnumerator LoadMainMenuAfterDelay()
    {
        yield return new WaitForSeconds(2f);
        Loader.Instance.LoadScene("MainMenu");
    }
    
}

