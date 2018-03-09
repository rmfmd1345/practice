using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float jump;
    public int speed;

    private Rigidbody2D m_rigid;
    public GameObject cubw2;

    //public int a { get { return _a; } set { _a = a; } }
    //private int _a;

	// Use this for initialization
	void Start () {
        m_rigid = GetComponent<Rigidbody2D>();
        cubw2.GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
        {
            m_rigid.velocity = Vector2.zero;
            m_rigid.AddForce(new Vector2(0, jump * 1000));
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(+speed * Time.deltaTime, 0);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Debug.Log("충돌");
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        
    }
}
