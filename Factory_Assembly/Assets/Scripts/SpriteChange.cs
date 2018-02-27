using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChange : MonoBehaviour
{
    public Sprite part1;
    public Sprite part2;
    public string tagName;

    private SpriteRenderer spriteRenderer;

    // Use this for initialization
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer.sprite == null)
            spriteRenderer.sprite = part1;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == tagName)
        {
            changeSprite();
            Destroy(other.gameObject);
        }
    }

    void changeSprite()
    {
        if (spriteRenderer.sprite == part1) // if the spriteRenderer sprite = sprite1 then change to sprite2
        {
            Debug.Log("Change");
            spriteRenderer.sprite = part2;
        }
        else
        {
            spriteRenderer.sprite = part1; // otherwise change it back to sprite1
        }
    }
}
