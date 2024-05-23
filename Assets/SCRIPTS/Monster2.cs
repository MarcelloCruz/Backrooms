using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Audio;
public class Monster2 : MonoBehaviour
{
    public GameObject player;
    private NavMeshAgent agent;
    public float timer;
    public float soundtimer = 10;
    private Animator anim;
    public PlayerScene2 playerScript;
    // public AudioSource audioSource1;

    //public AudioClip a1;
    //public AudioClip a2;
    // public AudioClip a3;
    //private bool canFollow = false;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        soundtimer += Time.deltaTime;

        Debug.Log(agent.remainingDistance);
        agent.SetDestination(player.transform.position);
        if (agent.remainingDistance < 3 && agent.remainingDistance > 0 && timer > 2)
        {
            player.GetComponent<PlayerScene2>().healthSlider.value -= 35;
            anim.SetBool("attack", true);
            timer = 0;
            playerScript.health -= 35;
        }

        /*if (agent.remainingDistance < 40 && agent.remainingDistance > 0 && soundtimer > 5)
        {

            audioSource1.PlayOneShot(a1);
            soundtimer = 0;

        }
        if (agent.remainingDistance < 40 && agent.remainingDistance > 0 && soundtimer > 5)
        {
            audioSource1.PlayOneShot(a2);
            soundtimer = 0;

        }
        else if (agent.remainingDistance < 15 && agent.remainingDistance > 0 && soundtimer > 5)
        {
            audioSource1.PlayOneShot(a3);
            soundtimer = 0;
        }*/

    }

    private void OnTriggerEnter(Collider other)
    {
        /*if (other.gameObject.name.Equals("FPSController"))
        {
            canFollow = true;
        }
        else canFollow = false;*/
    }
}
