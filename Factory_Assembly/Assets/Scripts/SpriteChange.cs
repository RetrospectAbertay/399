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

    DisableTriggers disableTriggers;
    GameObject triggerGameObject;
    public string triggerName;

    // Use this for initialization
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer.sprite == null)
            spriteRenderer.sprite = firstSprite;
        triggerGameObject = GameObject.Find(triggerName);

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
        disableTriggers = triggerGameObject.GetComponent<DisableTriggers>();

        // if the spriteRenderer sprite = sprite1 then change to sprite2
        if (spriteRenderer.sprite == firstSprite) 
        {
            Debug.Log("Change");
            spriteRenderer.sprite = secondSprite;
            StartCoroutine(Flashing());
            spriteRenderer.sprite = secondSprite;
            canMove = true;
            disableTriggers.deactivateCollider();
            
        }
        //else
        //{
        //    // otherwise change it back to sprite1
        //    spriteRenderer.sprite = firstSprite; 
        //    canMove = false;
        //}
    }

    IEnumerator Flashing()
    {
        for (int i = 0; i < 4; i++)
        {
            spriteRenderer.material.color = Color.black;
            //spriteRenderer.color = new Color(spriteRenderer.color.r + 40, spriteRenderer.color.g + 40, spriteRenderer.color.b + 40, 1);
            yield return new WaitForSeconds(0.01f);
            //spriteRenderer.color = new Color(spriteRenderer.color.r - 40, spriteRenderer.color.g - 40, spriteRenderer.color.b - 40, 1);
            spriteRenderer.material.color = Color.white;
            yield return new WaitForSeconds(0.01f);

        }
    }

    public bool getBool()
    {
        return canMove;
    }
}
