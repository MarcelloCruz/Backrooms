using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class G : MonoBehaviour
{
    public int counter;
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnEnemy", 0, 1f);
  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
