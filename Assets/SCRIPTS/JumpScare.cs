using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class scare : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;
    public GameObject jumpScare;
    public player playerScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playerScript.JumpScare();
            StartCoroutine(TimeOnScreen());
        }
    }

   

    IEnumerator TimeOnScreen()
    {
        yield return new WaitForSeconds(1.2f);
        jumpScare.SetActive(false);
    }
}
