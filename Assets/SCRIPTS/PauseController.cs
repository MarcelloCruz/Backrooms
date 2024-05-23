using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour
{
    public UnityEvent GamePaused;
    public UnityEvent GameResumed;
    public GameObject pauseMenu;
    public GameObject gameUI;


    private bool _isPaused;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            _isPaused = !_isPaused;
            pauseMenu.SetActive(true);
            gameUI.SetActive(false);

           if (_isPaused)
            {
                Time.timeScale = 0;
                GamePaused.Invoke();
            }

           else
            {
                Time.timeScale = 1;
                GameResumed.Invoke();
                gameUI.SetActive(true);
                pauseMenu.SetActive(false);
            }
        }
    }

    
        

}
