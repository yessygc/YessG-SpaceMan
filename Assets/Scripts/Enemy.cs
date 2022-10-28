using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float runningSpeed = 1.5f;

    Rigidbody2D rigidBody2D;

    public bool facingright = false;

    private Vector3 startPosition;

    private void Awake() {
        rigidBody2D = GetComponent<Rigidbody2D>();
        startPosition = this.transform.position;
    }
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = startPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
