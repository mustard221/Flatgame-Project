using UnityEngine;

public class butterflyTrig : MonoBehaviour
{
    public GameObject butterfly;
    private butterflyMove butterflyScript;
    AudioSource wings;
    AudioSource flight;

    public void Start()
    {
        flight = butterfly.GetComponent<AudioSource>();
        wings = GetComponent<AudioSource>();
        butterflyMove butterflyScript = butterfly.GetComponent<butterflyMove>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // set isMoving bool from butterfly script to true when player enters the trigger
        if (collision.gameObject.tag == "Player")
        {
            butterflyMove butterflyScript = butterfly.GetComponent<butterflyMove>();
            butterflyScript.isMoving = true;
            flight.Play();
            wings.Play();
        }

        // if player collides again, sound shouldn't play again and butterfly doesn't need to trigger
            if (collision.gameObject.tag == "Player" && butterflyScript.isMoving == true)
            {
                return;
            }
    }
}
