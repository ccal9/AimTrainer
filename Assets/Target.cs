using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
 

    // Start is called before the first frame update
    void Start()
    {
       
    }

     void OnClick()
    {
        AimTrainer.score += 10;
        AimTrainer.targetsHit +=1;
        Destroy(gameObject);
    }

    public void FixedUpdate()
    {
 
    }

    // Update is called once per frame
    void Update()
    {

    }
}
