using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private float timer = 1f;
    [SerializeField] private GameObject obstaculo;
    [SerializeField] private Vector3 posicaoObstaculo;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            timer = 1f;
            Instantiate(obstaculo, posicaoObstaculo, Quaternion.identity);
        }
    }
}
