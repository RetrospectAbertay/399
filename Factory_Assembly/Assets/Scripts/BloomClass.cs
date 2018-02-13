using UnityEngine;
using System.Collections;


[ExecuteInEditMode]
public class BloomClass : MonoBehaviour
{

    public Material material;
    // Use this for initialization
    void Start()
    {
        material = new Material(Shader.Find("Sprites/ItemGlow"));
    }

    public void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        material.SetTexture("_MainTex", source);
        Graphics.Blit(source, destination, material);
    }
}