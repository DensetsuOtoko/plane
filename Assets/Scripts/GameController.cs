using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private float timer = 1.5f;
    [SerializeField] private float timerMin = 0.6f;
    [SerializeField] private float timerMax = 2.5f;
    [SerializeField] private float posMin = -1.32f;
    [SerializeField] private float posMax = 1.75f;
    [SerializeField] private GameObject obstaculo;
    [SerializeField] private Vector3 posicaoObstaculo;
    private float pontos = 0f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GerandoObstaculos();
        GerandoPontos();
    }

    private void GerandoObstaculos()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            posicaoObstaculo.y = Random.Range(posMin, posMax);
            Instantiate(obstaculo, posicaoObstaculo, Quaternion.identity);
            timer = Random.Range(timerMin, timerMax);
        }
    }

    private void GerandoPontos()
    {
        pontos += Time.deltaTime;
        Debug.Log(Mathf.Round(pontos));
    }
}
