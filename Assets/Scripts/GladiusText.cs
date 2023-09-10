using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GladiusText : MonoBehaviour
{
    [SerializeField] //added this attibute which will affect the `gameManager` variable
    private GameManager gameManager;
    public GameObject gameObject;
    private void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.swordGrabbed)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }
    }
}
