using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int Speed = 10;
    Rigidbody2D _rb;
    Vector2 _vel;
    Vector2 _input;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _vel = new Vector2(Speed, Speed);
    }

    void Update()
    {
        _input = new Vector2(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical")
        );
    }

    void FixedUpdate()
    {
        var delta = _input * _vel * Time.deltaTime;
        var newPos = _rb.position + delta;
        _rb.MovePosition(newPos);

    }
}
