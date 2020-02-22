using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Target : MonoBehaviour
{
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 2f);
    }

     void OnMouseDown()
    {
        Destroy(this.gameObject);
    }

    public void FixedUpdate()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        
        /*if (Input.GetMouseButtonDown(0))
        {
            AimTrainer.score += 10;
            AimTrainer.targetsHit += 1;
            Destroy(this.gameObject);
        }*/
    }
    
}
