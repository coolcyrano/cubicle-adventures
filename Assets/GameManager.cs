using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{ bool gameHasEnded = false;
public float restartDelay = 2f;
public GameObject CompleteLevelUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void EndGame()
    {
        if (gameHasEnded == false)
        gameHasEnded = true;
        Debug.Log("hello there anekin");
        Invoke("Restart", restartDelay);
        
    }
    void Restart()
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void CompleteLevel()
    {
        CompleteLevelUI.SetActive(true);
    }
}
