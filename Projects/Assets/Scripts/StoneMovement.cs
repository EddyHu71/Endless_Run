using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneMovement : MonoBehaviour
{
    float speedStone = 3f;
    float move;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

    }
    // Update is called once per frame
    void Update()
    {
        move = (speedStone * Time.deltaTime * -1f) + transform.position.x;
        transform.position = new Vector2(move, transform.position.y);
        if (transform.position.x <= -4.5f)
        {
            Destroy(gameObject);
        }
    }
}
