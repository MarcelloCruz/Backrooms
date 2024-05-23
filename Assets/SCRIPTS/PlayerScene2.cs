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
    public float health;
    public Slider healthSlider;
    public GameObject cardReader;
    public GameObject card;
    public bool vf = false;
    public GameObject cardOn;
    public GameObject portal;



   
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
            if (hit.transform.gameObject.tag.Equals("card") && Input.GetKeyDown(KeyCode.E))
            {
                vf = true;
                Destroy(hit.transform.gameObject);
                
            }

            if (hit.transform.gameObject.tag.Equals("cardreader") && Input.GetKeyDown(KeyCode.E))
            {
                if (vf)
                {
                    CardOn();
                    portal.SetActive(true);
                }
                

            }


        }


        /*anim.SetFloat("vertical", Input.GetAxis("vertical"));
        anim.SetFloat("horizontal", Input.GetAxis("horizontal"));*/

        /*if (Input.GetKeyDown(KeyCode.F))
        {
            playerController.m_IsWalking;
        }*/
    }

    public void CardOn()
    {
        cardOn.SetActive(true);
    }



   

   


   




}
