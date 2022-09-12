using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float _MovementSpeed;
    private Animator _anim;
    private Rigidbody2D _rb;
    private Vector2 _MovementInput;


    // Start is called before the first frame update
    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        Move();
        Animate();

    }

    private void Move()
    {
        float _Horizontal = Input.GetAxisRaw("Horizontal");
        float _Vertical= Input.GetAxisRaw("Vertical");
        

        if(_Horizontal == 0 && _Vertical == 0)
        {
            _rb.velocity = new Vector2(0, 0);
            return;
        }

        _MovementInput = new Vector2(_Horizontal, _Vertical);
        _rb.velocity = _MovementInput * _MovementSpeed * Time.fixedDeltaTime;
    }
    private void Animate()
    {
        _anim.SetFloat("MovementX", _MovementInput.x);
        _anim.SetFloat("MovementY", _MovementInput.y);
    }
}
