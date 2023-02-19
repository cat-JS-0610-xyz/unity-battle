using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class man : MonoBehaviour
{
    // Start is called before the first frame update
    SpriteRenderer r;
    Rigidbody2D h;
    public float dirofX;
    float jumpforce = 10f;//3.4f;
    public bool mayjump = true;
    public Transform groundcheck;
    private Animator anim;
    public GameObject arrow;
    public int hp = 3;
    public bool dead = false;
    void shoot()
    {
        GameObject newarrow;
        newarrow = Instantiate(arrow, transform.position,Quaternion.identity);
    }
    public enum states {
        indling, //0
        walking, //1
        jumping, //2
    };
    private states statess
    {
        get { return (states)anim.GetInteger("stateinteger");}
        set { anim.SetInteger("stateinteger", (int)value);}
    }
    void Start()
    {
        h = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        r = GetComponent<SpriteRenderer>();
        r.color = Color.green;
        mayjump = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (dead == false)
        {
            dirofX = Input.GetAxis("Horizontal");
            if (Input.GetKeyDown(KeyCode.W) && mayjump)
            {
                h.AddForce(new Vector2(0, jumpforce), ForceMode2D.Impulse);
            }
            if (Input.GetMouseButtonDown(0))
            {
                shoot();
            }
            if (dirofX < 0)
            {
                r.flipX = true;
                r.color = Color.red;
            }
            else if (dirofX > 0)
            {
                r.flipX = false;
                r.color = Color.cyan;
            }

            if (mayjump)
            {
                if (dirofX == 0)
                {
                    statess = states.indling;
                }
                else
                {
                    statess = states.walking;
                }
            }
            else
            {
                statess = states.jumping;
            }
        }
    }
    private void FixedUpdate()
    {
        h.velocity = new Vector2(dirofX * 7f, h.velocity.y);
        RaycastHit2D raytoground = Physics2D.Raycast(groundcheck.position, Vector2.down, 2f);
        Debug.DrawRay(groundcheck.position, Vector2.down * raytoground.distance);
        if (raytoground.collider != null)
        {
            if (raytoground.collider.tag == "ground")
                if (raytoground.distance <= 0.2f) mayjump = true;
                else mayjump = false;
        }
    }
}
