using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    public void RestartGame () 
    {
        SceneManager.LoadScene("SampleScene");
    }
}
