using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimTrainer : MonoBehaviour
{
    [Header("Set in Inspector")]
    public GameObject targetPrefab;
    public int maxTargets = 30;
    public float maxScale = 3f;
    public float frequency = 1.5f;

    [Header("Set Dynamically")]
    public float speed;
    public int score;
    public int targetsHit;
    public int targetCount;
    private Vector3 targetPos;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        targetsHit = 0;
        targetCount = 0;
        //targetPos = transform.position;
        spawnTargets();
    }

    public IEnumerator spawnTargets()
    {
        for (int n = 0; n < maxTargets; n++)
        {
            targetPos = new Vector3(Random.Range(-30, 30), Random.Range(-15, 15), 0);
            GameObject Ctarget = Instantiate<GameObject>(targetPrefab, targetPos, Quaternion.identity);
            targetCount += 1;
            if (targetCount % 2 == 0 && !(frequency <= 0))
            {
                frequency -= .1f;
            }
            yield return new WaitForSeconds(frequency);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
