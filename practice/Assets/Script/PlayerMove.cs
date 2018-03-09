using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class PlayerMove : MonoBehaviour {
    public enum STATE_KIND
    {
        LEFT,
        RIGHT
    }
    public STATE_KIND kind;
    private SpriteRenderer sp;
    private Rigidbody2D rb;
    public int speed;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        sp = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-speed * Time.deltaTime, 0);
            kind = STATE_KIND.LEFT;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0);
            kind = STATE_KIND.RIGHT;
        }
        switch(kind)
        {
            case STATE_KIND.LEFT:
                sp.flipX = true;
                break;
            case STATE_KIND.RIGHT:
                sp.flipX = false;
                break;
        }
	}
}
