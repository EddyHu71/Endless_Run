using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateStone : MonoBehaviour
{
    // Start is called before the first frame update
    public float timer = 3f;
    float timeStone;
    float timeCount;
    public GameObject stone;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeCount += Time.deltaTime;
        timeStone = Random.Range(3f, 5f);

        if (timeCount > timeStone)
        {
            Instantiate(stone, transform.position, transform.rotation);
            timeCount = 0;
        }
    }
}
