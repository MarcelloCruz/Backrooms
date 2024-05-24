using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scare2 : MonoBehaviour
{
    //public AudioSource audioSource;
    //public AudioClip audioClip;
    public GameObject jumpScare;
    public PlayerScene2 playerScript;
    public bool canActivate = true;
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
            if (playerScript.canActivate = true)
            {
                playerScript.JumpScare();
                canActivate = false;
            }



        }



    }


    IEnumerator TimeOnScreen()
    {
        yield return new WaitForSeconds(1.2f);
        jumpScare.SetActive(false);
    }


}
