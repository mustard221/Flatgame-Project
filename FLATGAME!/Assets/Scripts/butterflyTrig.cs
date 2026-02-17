using UnityEngine;

public class butterflyTrig : MonoBehaviour
{
    public GameObject butterfly;
    AudioSource wings;
    AudioSource flight;

    public void Start()
    {
        flight = butterfly.GetComponent<AudioSource>();
        wings = GetComponent<AudioSource>();
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
    }
}
