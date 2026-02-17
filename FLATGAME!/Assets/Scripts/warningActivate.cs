using UnityEngine;

public class warningActivate : MonoBehaviour
{
    public GameObject trigger;

    private void OnTriggerExit2D(Collider2D collision)
    {
        trigger.SetActive(true); // activate wall trigger after passing into next area
    }
}
