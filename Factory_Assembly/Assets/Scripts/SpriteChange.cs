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
        // if the spriteRenderer sprite = sprite1 then change to sprite2
        if (spriteRenderer.sprite == firstSprite) 
        {
            Debug.Log("Change");
            spriteRenderer.sprite = secondSprite;
            StartCoroutine(Flashing());
            spriteRenderer.sprite = secondSprite;
            canMove = true;
        }
        else
        {
            // otherwise change it back to sprite1
            spriteRenderer.sprite = firstSprite; 
            canMove = false;
        }
    }

    IEnumerator Flashing()
    {
        for (int i = 0; i < 2; i++)
        {
           // spriteRenderer.material.color = Color.black;
            yield return new WaitForSeconds(0.001f);
            //spriteRenderer.material.color = Color.white;
            yield return new WaitForSeconds(0.001f);

        }
    }

    public bool getBool()
    {
        return canMove;
    }
}
