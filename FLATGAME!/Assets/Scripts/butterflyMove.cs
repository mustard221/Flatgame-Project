using UnityEngine;

public class butterflyMove : MonoBehaviour
{
    public bool isMoving = false;
    public float moveSpeed;

    void Update()
    {
        if (isMoving == true)
        {
            transform.Translate(Vector3.up * Time.deltaTime * moveSpeed);
        }
    }
}
