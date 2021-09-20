using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D meuRb;
    private Transform transformAviao;
    private float regraLimiteTetoFundo = 5.80f;
    [SerializeField] private float velocidade = 2.5f;

    void Start()
    {
        meuRb = GetComponent<Rigidbody2D>();
        transformAviao = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Subir();
        LimitandoVelocidade();
        RegraAviao();
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

    private void RegraAviao()
    {
        float y = transformAviao.position.y;
        if (y > regraLimiteTetoFundo || y < -regraLimiteTetoFundo)
        {
            ReiniciarJogo();
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        ReiniciarJogo();
    }
    private void ReiniciarJogo()
    {
        SceneManager.LoadScene("Jogo");
    }
}
