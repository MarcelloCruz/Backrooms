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
    public GameObject leverOn;
    public GameObject leverOff;
    public bool lever = false;
    public GameObject powerOn;
    public GameObject jumpScare;
    public AudioSource audioSource;
    public AudioClip audioClip;
    public bool canActivate = true;
    //public GameObject generatorOn;





    void Start()
    {
        playerController = gameObject.GetComponent<FirstPersonController>();
        
    }
    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            //Debug.Log("mort");
            JumpScare();
            StartCoroutine(TimeOnScreen());
        }

       

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 4))
        {
            if (hit.transform.gameObject.tag.Equals("card") && Input.GetKeyDown(KeyCode.E))
            {
                vf = true;
                Destroy(hit.transform.gameObject);
                
            }

            if (hit.transform.gameObject.tag.Equals("lever") && Input.GetKeyDown(KeyCode.E))
            {
                leverOn.SetActive(true);
                leverOff.SetActive(false);
                lever = true;
                
            }
            if (lever)
            {
                PowerOn();
            }
            

            if (hit.transform.gameObject.tag.Equals("cardreader") && Input.GetKeyDown(KeyCode.E))
            {
                if (vf)
                {
                    lever = false;
                    PowerOff();
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

    public void PowerOn()
    {
        powerOn.SetActive(true);
    }

    public void PowerOff()
    {
        powerOn.SetActive(false);
    }

    public void JumpScare()
    {
        jumpScare.SetActive(true);
        audioSource.PlayOneShot(audioClip);
        StartCoroutine(TimeOnScreen2());
        canActivate  = false;
        


    }

    IEnumerator TimeOnScreen()
    {
        yield return new WaitForSeconds(1.2f);
        SceneManager.LoadScene("GameOver");
    }

    IEnumerator TimeOnScreen2()
    {
        yield return new WaitForSeconds(1.2f);
        jumpScare.SetActive(false);
    }

    IEnumerator Cooldown()
    {
        yield return new WaitForSeconds(3);
        canActivate = true;
    }













}
