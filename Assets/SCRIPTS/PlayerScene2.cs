using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.Audio;

public class PlayerScene2 : MonoBehaviour
{
    public GameObject crosshair;
    FirstPersonController playerController;
    
    
    

    // public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        playerController = gameObject.GetComponent<FirstPersonController>();
        
    }
    // Update is called once per frame
    void Update()
    {
        /*if (health <= 0)
        {
            //Debug.Log("mort");
            JumpScare();
            StartCoroutine(TimeOnScreen());
        }*/

        /*if (canActivate == false)
        {
            StartCoroutine(Cooldown());
        }*/

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 4))
        {
            //KEY


        }


        /*anim.SetFloat("vertical", Input.GetAxis("vertical"));
        anim.SetFloat("horizontal", Input.GetAxis("horizontal"));*/

        /*if (Input.GetKeyDown(KeyCode.F))
        {
            playerController.m_IsWalking;
        }*/
    }



   

   


   




}
