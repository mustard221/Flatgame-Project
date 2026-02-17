using UnityEngine;

public class warning : MonoBehaviour
{
    AudioSource warn;
    public AudioSource gong;
    public GameObject player;
    public GameObject txt;
    public float posX;

    void Start()
    {
        warn = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && !txt.activeSelf) // warn player if entering the area
        {
            gong.Play();
            warn.Play();
            txt.SetActive(true);
            collision.gameObject.transform.position = new Vector3(posX, -8, 0);
        }
        else if (collision.gameObject.CompareTag("Player") && txt.activeSelf) // if player enters again, reset position
        {
            gong.Play();
            warn.Play();
            collision.gameObject.transform.position = new Vector3(posX, -8, 0);
        }
    }
}
