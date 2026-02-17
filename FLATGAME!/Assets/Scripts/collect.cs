using UnityEngine;

public class collect : MonoBehaviour
{
    AudioSource gong;
    SpriteRenderer spriteRenderer;

    void Start()
    {
        gong = GetComponent<AudioSource>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("collided!");

        if (other.gameObject.CompareTag("Player"))
        {
            gong.Play();
            spriteRenderer.enabled = false; // play sound then disappear
            //hide children too
                foreach (Transform child in transform)
                {
                    SpriteRenderer childSpriteRenderer = child.GetComponent<SpriteRenderer>();
                    if (childSpriteRenderer != null)
                    {
                        childSpriteRenderer.enabled = false;
                    }
                }
            //set sound vol to 0 when clip is done so it repeat on collision
            Invoke("StopSound", gong.clip.length);
        }
    }
    void StopSound()
    {
        gong.volume = 0f;
    }
}

