using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ObstaculoController : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform transform;
    [SerializeField] private float velocidade = 5f;
    void Start()
    {
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        /* movendo montanhas para a esquerda*/
        transform.position += Vector3.left * Time.deltaTime * velocidade;
    }
}
