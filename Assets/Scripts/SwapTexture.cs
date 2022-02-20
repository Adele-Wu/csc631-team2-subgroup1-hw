// swap textures w/ spacebar

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapTexture : MonoBehaviour
{
    public Texture[] textures;
    public int currentTexture;

    // Update is called once per frame
    void Update () {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            currentTexture++;
            currentTexture %= textures.Length;
            GetComponent<Renderer>().material.mainTexture = textures[currentTexture];
        } 
    }
}
