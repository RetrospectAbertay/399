using UnityEngine;
using System.Collections;


[ExecuteInEditMode]
public class CRTClass : MonoBehaviour
{

    public Material material;
    // Use this for initialization
    void Start()
    {
        material = new Material(Shader.Find("Sprites/CRTShader"));
    }

    public void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        material.SetTexture("_MainTex", source);
        Graphics.Blit(source, destination, material);
    }
}