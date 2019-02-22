using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    bool jumping = false;
    bool dead = false;
    Rigidbody2D rb;
    private Animator anim;
    private AudioSource audioSource;
    public AudioClip audioClip;
    float changescene;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = audioClip;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && jumping == false && dead == false)
        {
            rb.AddForce(new Vector2(rb.velocity.x, 220f));
            jumping = true;
            Jump();
            Debug.Log("Jump");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Stone")
        {
            dead = true;
            Dead();
            Debug.Log("Die");
            SceneManager.LoadScene("gameover");
        } 
        if (collision.gameObject.tag == "Coin")
        {
            audioSource.Play();
            Debug.Log("Coin");
        }
        if (collision.gameObject.tag == "Land")
        {
            jumping = false;
            Walk();
            Debug.Log("Land");
        }
    }

    void Jump()
    {
        anim.SetBool("isJump", true);
        anim.SetBool("isWalk", false);
        anim.SetBool("isDead", false);
    }

    void Dead()
    {
        anim.SetBool("isJump", false);
        anim.SetBool("isWalk", false);
        anim.SetBool("isDead", true);
    }

    void Walk()
    {
        anim.SetBool("isWalk", true);
        anim.SetBool("isJump", false);
        anim.SetBool("isDead", false);
    }
}
