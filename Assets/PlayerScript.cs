using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float jumpStrength = 5;
    public LogicScript logic;
    public bool isAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody.velocity = Vector2.up * jumpStrength ;
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isAlive)
            myRigidbody.velocity = Vector2.up * jumpStrength;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isAlive = false;
        logic.gameOver();
    }

    public bool IsAlive()
    {
        return isAlive;
    }
}
