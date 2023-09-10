using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DragonController : MonoBehaviour
{

    [SerializeField] //added this attibute which will affect the `gameManager` variable
    private GameManager gameManager;

    [SerializeField]
    private TextMeshPro dragonHP;

    const string HPT = "HP: ";
    private int HP;
    public float speed = 1.0f;
	public float minDist = 1f;
	public Transform target;


	const string targetTag = "MainCamera";

	// Use this for initialization
	void Start()
	{
        HP = gameManager.getDragonHP();
        // if no target specified, assume the player main camera
        if (target == null)
        {

            if (GameObject.FindWithTag(targetTag) != null)
            {
                target = GameObject.FindWithTag(targetTag).GetComponent<Transform>();
            }
        }

        dragonHP.text = HPT + HP;
    }

	// Update is called once per frame
	void Update()
	{
        HP = gameManager.getDragonHP();

        if (target == null)
            return;

        // face the target
        transform.LookAt(target);

        //get the distance between the chaser and the target
        float distance = Vector3.Distance(transform.position, target.position);

        //so long as the chaser is farther away than the minimum distance, move towards it at rate speed.
        if (distance > minDist)
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        dragonHP.text = HPT + HP;

    }

	// Set the target of the chaser
	public void SetTarget(Transform newTarget)
	{
		target = newTarget;
	}

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Weapon"))
        {
            Debug.Log("Dragon got stab");
            gameManager.updateDragonHP(1);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Weapon"))
        {
            Debug.Log("Dragon got stab on collision");
            gameManager.updateDragonHP(1);
        }
    }
}
