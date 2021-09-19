using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ObstaculoController : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform transform;
    [SerializeField] private float velocidade = 5f;
    [SerializeField] private GameObject myself;
    [SerializeField] private GameController gameController;
    void Start()
    {
        transform = GetComponent<Transform>();
        gameController = FindObjectOfType<GameController>();
        Destroy(myself, 9f);
    }

    // Update is called once per frame
    void Update()
    {
        /* movendo montanhas para a esquerda*/
        transform.position += Vector3.left * Time.deltaTime * RetornandoVelocidadeDeAcordoComLevel();
    }

    private float RetornandoVelocidadeDeAcordoComLevel()
    {
        return velocidade + gameController.RetornaLevel();
    }
}
