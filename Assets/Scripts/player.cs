using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private Rigidbody2D _playerRigidbody;
    [SerializeField] private Collider2D _playerCollider;
    [SerializeField] private Collider2D _groundCollider;

    private bool _isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        _isGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
        {
            _playerRigidbody.AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
            _isGrounded = false;
        }
    }
}
