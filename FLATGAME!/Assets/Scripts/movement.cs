using UnityEngine;

public class movement : MonoBehaviour
{
    public AudioSource sound;

    void Start()
    {
        float hInput = Input.GetAxis("Horizontal"); // get player input
        float vInput = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        //applying input to movement
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * Time.deltaTime * 6);
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * Time.deltaTime * 6);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * 6);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * 6);
        }

        //play sound when moving
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            if (!sound.isPlaying)
            {
                sound.Play();
            }
        }
        else
        {
            sound.Stop();
        }
    }
}
