using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class SwordController : MonoBehaviour
{
    [SerializeField] //added this attibute which will affect the `gameManager` variable
    private GameManager gameManager;


    
    //private TextMesh text;
    //// Start is called before the first frame update
    //void Start()
    //{
    //    text = this.gameObject.GetComponent<TextMesh>();
    //}

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("GameController"))
        {

            gameManager.swordGrabbed = true;
        }
    }

    public void onGrabg(XRBaseInteractor onj)
    {
        gameManager.swordGrabbed = true;
        //Debug.Log("Grabb");
    }

    public void onLost(XRBaseInteractor onj)
    {
        gameManager.swordGrabbed = false;
        //Debug.Log("Grabb");
    }
}
