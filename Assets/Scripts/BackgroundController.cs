using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    private Renderer background;
    private float offset = 0f;
    private float velocidade = 0.1f;
    private Vector2 textureOffset;


    // Start is called before the first frame update
    void Start()
    {
        background = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        offset += Time.deltaTime * velocidade;
        textureOffset.x = offset;
        background.material.mainTextureOffset = textureOffset;
    }
}
