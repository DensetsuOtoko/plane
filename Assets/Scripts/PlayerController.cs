using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D meuRb;
    [SerializeField] private float velocidade = 2.5f;

    void Start()
    {
        meuRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Subir();
        LimitandoVelocidade();
    }

    private void Subir()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            meuRb.velocity = Vector2.up * velocidade;
        }
    }

    private void LimitandoVelocidade()
    {
        if (meuRb.velocity.y < -velocidade)
        {
            meuRb.velocity = Vector2.down * velocidade;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene("Jogo");
    }
}
