using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChange : MonoBehaviour
{
    public Sprite firstSprite;
    public Sprite secondSprite;
    public string tagName;
    bool canMove;
    private SpriteRenderer spriteRenderer;

    // Use this for initialization
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer.sprite == null)
            spriteRenderer.sprite = firstSprite;

        canMove = false;
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
        if (spriteRenderer.sprite == firstSprite) // if the spriteRenderer sprite = sprite1 then change to sprite2
        {
            Debug.Log("Change");
            spriteRenderer.sprite = secondSprite;
            canMove = true;
        }
        else
        {
            spriteRenderer.sprite = firstSprite; // otherwise change it back to sprite1
        }
    }

    public bool getBool()
    {
        return canMove;
    }
}
