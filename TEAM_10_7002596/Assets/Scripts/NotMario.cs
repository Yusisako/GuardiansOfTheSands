using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class NotMario : MonoBehaviour
{
    private float h;

    private Rigidbody2D rb;
    private BoxCollider2D bc;

    private Animator animator;
    private int nbJump;
    private float timeJump;
    private float timeNbJump;
    private bool isJumping;
    private bool isHurt;
    private float timeIsHurt;
    public int hp;
    public GameObject Life;
    private RectTransform rectHeart;
    public int coin;
    private AudioSource audioSource;
    public TextMeshProUGUI coinText;
    public AudioClip hurt;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        bc = GetComponent<BoxCollider2D>();
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        rectHeart = Life.GetComponent<RectTransform>();
        nbJump = 0;
        timeNbJump = 0;
        timeJump = 0;
        isJumping = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rectHeart.sizeDelta = new Vector2( 55 * hp, 50); // permet d'afficher la vie de mario en fonction de ses hp.
        h = Input.GetAxisRaw("Horizontal");
        if (!isHurt)
        {
            if (h != 0)
            {
                rb.velocity = new Vector2(h * 5, rb.velocity.y);
                transform.localScale = new Vector3(h, 1, 1);
            }
            else
            {
                rb.velocity = new Vector2(0, rb.velocity.y);
            }

            animator.SetBool("IsWalking", h != 0);
            Jump();
        }
        
        if (timeIsHurt > 0 && (Time.fixedTime - timeIsHurt >= 1))
        {
            if (hp <= 0)
            {
                SceneManager.LoadScene("Lose");
            }
            timeIsHurt = 0;
            isHurt = false;
            animator.SetBool("IsHurt", false);
        }
        

        //print(rb.velocity);
    }

    void CheckTimeNbJump()
    {
        if ((Time.fixedTime - timeNbJump > 1.5) && timeNbJump > 0)
        {
            timeNbJump = 0;
            nbJump = 0;
        }
    }

    void TimeJump()
    {
        if (!Input.GetKey(KeyCode.Space))
        {
            timeJump = 0;
        }

        if ((Time.fixedTime - timeJump > 0.2) && timeJump > 0)
        {
            timeJump = 0;
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y + 2);
        }
    }
    void Jump()
    {
        if (Input.GetKey((KeyCode.Space)) && !isJumping)
        {
            
            isJumping = true;
            animator.SetBool("IsJumping", isJumping);
            timeJump = Time.fixedTime;
            timeNbJump = Time.fixedTime;
            nbJump += 1;
            
            if (nbJump >= 3)
            {
                rb.velocity = new Vector2(rb.velocity.x, 8);
                nbJump = 0;
            } else
            {
                rb.velocity = new Vector2(rb.velocity.x, 5);
            }
        }
        CheckTimeNbJump();
        TimeJump();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.GetComponent<Enemy>() && !(col.GetComponent<Enemy>().getIsHurt()))
        {
            audioSource.PlayOneShot(hurt);
            hp -= 1;
            isHurt = true;
            animator.SetBool("IsHurt", isHurt);
            timeIsHurt = Time.fixedTime;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        isJumping = false;
        animator.SetBool("IsJumping", isJumping);
        //Debug.Log("OnCollisionEnter2D");
    }
    /*void OnCollisionExit2D(Collision2D col)
    {
        //Debug.Log("OnCollisionExit2D");
        isJumping = true;
        animator.SetBool("IsJumping", isJumping);
    }*/

    public void AddCoin(AudioClip clip)
    {
        coin = coin + 1;
        print("patate" + coin);
        audioSource.PlayOneShot(clip);
        coinText.text = "coins:" + coin;
    }
}