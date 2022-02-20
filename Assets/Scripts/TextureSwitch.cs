// swap textures w/ button

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextureSwitch: MonoBehaviour
{
    [SerializeField]
    private GameObject cube;

    [SerializeField]
    private Texture[] textures;

    private Renderer cubeRenderer;
    private int randomTextureIndex;

    // Start is called before the first frame update
    void Start()
    {
        cubeRenderer = cube.GetComponent<Renderer>();
        gameObject.GetComponent<Button>().onClick.AddListener(ChangeCubeTexture);
    }

    private void ChangeCubeTexture()
    {
        randomTextureIndex = Random.Range (0, textures.Length);
        cubeRenderer.material.mainTexture = textures[randomTextureIndex];
    }
}