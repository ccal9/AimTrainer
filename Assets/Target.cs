using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{

    [Header("Set in Inspector")]
    public GameObject targetPrefab;
    public int maxTargets = 7;
    public float maxScale = 3f;
    public float frequency = 2.5f;
    public float speed;
    

    private List<GameObject> Targets;
    // Start is called before the first frame update
    void Start()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
        }
        
        Targets = new List<GameObject>();

    }
    void spawnTarget(Vector2 spawnPos)
    {
        Vector3 pos = transform.position;
        Vector3 scale = transform.localScale;
        
        while( < )
        {
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("spawnTarget", frequency);
    }
}
