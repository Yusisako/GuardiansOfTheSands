using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    private float timeTurn;
    private bool isHurt;
    private float timeIsHurt;
    public int hp;
    public bool turn;
    public float x;
    public float y;
    public bool boss;
    public AudioClip hurt;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        timeTurn = 0;
        isHurt = false;
        rb.velocity = new Vector2(x, y);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.fixedTime - timeTurn > 2 && !isHurt)
        {
            if (turn)
            {
                x = -x;
                transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);

            }
            else
            {
                y = -y;
            }
            timeTurn = Time.fixedTime;
        }
        rb.velocity = new Vector2(x, y);
        if (timeIsHurt > 0 && (Time.fixedTime - timeIsHurt < 1))
        {
            rb.velocity = new Vector2(0, y);
        }
        else
        {
            if (hp <= 0)
            {
                if (boss)
                {
                    SceneManager.LoadScene("Win");
                }
                Destroy(this.gameObject);
            }
            timeIsHurt = 0;
            isHurt = false;
            anim.SetBool("IsHurt", false);
        }

    }

    public void IsHurt()
    {
        if (!isHurt)
        {
            audioSource.PlayOneShot(hurt);
            isHurt = true;
            anim.SetBool("IsHurt", isHurt);
            timeIsHurt = Time.fixedTime;
            hp -= 1;
            
        }
    }

    public bool getIsHurt()
    {
        return (isHurt);
    }
}
