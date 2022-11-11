using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAreas : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject objectToActivate;
    
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == player)
        {
            objectToActivate.SetActive(true);
            Debug.Log("did it");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject == player)
        {
            objectToActivate.SetActive(false);
            Debug.Log("did it again");
        }
    }

}
