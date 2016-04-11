using UnityEngine;
using System.Collections;

public class RobotMovementScript : MonoBehaviour {

    public float m_maxSpeed = 10f;
    public bool m_facingRight = true;

    public Rigidbody m_rigidBody;

	// Use this for initialization
	void Start () {
	
	}
	
    void FixedUpdate()
    {
        m_rigidBody.velocity = Vector3.zero;

        float move = Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.D))
        {
            m_rigidBody.velocity = new Vector3(m_maxSpeed, m_rigidBody.velocity.y, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            m_rigidBody.velocity = new Vector3(-m_maxSpeed, m_rigidBody.velocity.y, 0);
        }
        
        if (Input.GetKey(KeyCode.W))
        {
            //GetComponentInChildren
        }
    }

	// Update is called once per frame
	void Update () {
	
	}
}
