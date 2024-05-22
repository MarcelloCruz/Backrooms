using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.Audio;


public class player : MonoBehaviour
{
    public Slider healthSlider;
    public Animator anim;
    public float health;
    public GameObject jumpScare;
    public GameObject keyon;
    public GameObject crosshair;
    public bool cnt = false;
    public bool press = false;
    public GameObject button;
    FirstPersonController playerController;
    public GameObject buttonPressed;
    public GameObject buttonIdle;
    public GameObject portalOn;
    public GameObject portalOff;
    public AudioSource audioSource;
    public AudioClip audioClip;
    public bool canActivate = true;
    public GameObject path_to_key;
    public GameObject path_to_button;
    public GameObject mission1;
    public GameObject mission2;
    public GameObject mission3;

   // public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        playerController  = gameObject.GetComponent<FirstPersonController>();
        mission1.SetActive(true);
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

       if (canActivate == false)
        {
            StartCoroutine(Cooldown());
        }

       Ray ray =  Camera.main.ScreenPointToRay(Input.mousePosition);
       RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 4))
        {
            //KEY
            if (hit.transform.gameObject.tag.Equals("key") && Input.GetKeyDown(KeyCode.E))
            {
                cnt = true;
                Destroy(hit.transform.gameObject);
                Key();
                Debug.Log("cnt");
                path_to_key.SetActive(false);
                path_to_button.SetActive(true);
                mission1.SetActive(false);
                mission2.SetActive(true);
            }

            /*if (hit.transform.gameObject.tag.Equals("key"))
            {
                crosshair.transform.localScale = new Vector3(1.3f, 1.3f, 1.3f);
            }

            else
            {
                crosshair.transform.localScale = new Vector3(1, 1, 1);
            }*/

            //BUTOn
            if (hit.transform.gameObject.tag.Equals("button") && Input.GetKeyDown(KeyCode.E))
            {
                if (cnt)
                {
                    buttonIdle.SetActive(false);
                    buttonPressed.SetActive(true);
                    press = true;
                    path_to_button.SetActive(false);
                    mission2.SetActive(!true);
                    mission3.SetActive(true);
                }
              
            }
            
            if (press)
            {
                portalOn.SetActive(true);
            }
            
                      
        }


        /*anim.SetFloat("vertical", Input.GetAxis("vertical"));
        anim.SetFloat("horizontal", Input.GetAxis("horizontal"));*/

        /*if (Input.GetKeyDown(KeyCode.F))
        {
            playerController.m_IsWalking;
        }*/
    }

    public void JumpScare()
    {
        jumpScare.SetActive(true);
        audioSource.PlayOneShot(audioClip);
        StartCoroutine(TimeOnScreen2());
        canActivate = false;
        

    }

    public void Key()
    {
        keyon.SetActive(true);
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
