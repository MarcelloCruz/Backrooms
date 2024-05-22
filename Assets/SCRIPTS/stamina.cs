using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class stamina : MonoBehaviour
{
    public float stamin;
    float maximStamina;

    public Slider staminaSlider;
    public float dValue;
    FirstPersonController fps;

    // Start is called before the first frame update
    void Start()
    {
        maximStamina = stamin;
        staminaSlider.maxValue = maximStamina;
        fps = GetComponent<FirstPersonController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift)) {
            DecreaseEnergy(); 
        }
        else if (stamin != maximStamina)
        {
            IncreaseEnergy();
        }
          
        staminaSlider.value = stamin;

        if (staminaSlider.value > 0)
        {
            fps.canRun = true;
        }

        else
        {
            fps.canRun = false;      
        } 
        //Debug.Log(staminaSlider.value);
    }


    private void DecreaseEnergy()
    {
        if (stamin != 0 && stamin >= 0)
            stamin -= dValue * Time.deltaTime;
    }

    private void IncreaseEnergy()
    {
        if (stamin != 0 && stamin <= 100)
            stamin += dValue * Time.deltaTime;
        
    }

}
