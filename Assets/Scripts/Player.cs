using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D meuRb;
    [SerializeField] private float velocidade = 5f;

    void Start()
    {
        meuRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("pulou");
            meuRb.velocity = Vector2.up * velocidade;
        }

        if (meuRb.velocity.y < -velocidade)
        {
            meuRb.velocity = Vector2.down * velocidade;
        }
    }
}
