using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private Collider2D _playerCollider;
    [SerializeField] private float _jump = 5.0f;
    [SerializeField] private GameControl _gameControl;

    private bool _isGrounded;
    private int _points;
    // Start is called before the first frame update
    void Start()
    {
        _points = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
        {
            //_rigidbody.AddForce(Vector2.up * _jump, ForceMode2D.Impulse);
            _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, _jump);
            _isGrounded = false;
        }
        _gameControl.Updatepoint(_points);
        //Debug.Log("Points: " + _points);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _isGrounded = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            _points += 1;
            Destroy(collision.gameObject);
            
        }
    }
}
