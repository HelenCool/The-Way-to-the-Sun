using UnityEngine;
using System.Collections;

public class PlatformState : MonoBehaviour {

    public Transform target;
    public GameObject spawner;
   

    public float bounceFactor = 10f;

    bool hasSpawned=false;

	
	void Start () {
        spawner = GameObject.FindGameObjectWithTag("Respawn");
        target = GameObject.Find("Character").transform;
	}


    void Update()
    {

        if (gameObject.GetComponent<Collider2D>())
        {
            if (target.position.y < gameObject.transform.position.y + 0.2f)
            {
                gameObject.GetComponent<BoxCollider2D>().enabled = false;
            }
            else
            {
                gameObject.GetComponent<BoxCollider2D>().enabled = true;
            }
        }
    }

       /* if (!hasSpawned)
        {
           spawner.SendMessage("Spawn");
            hasSpawned = true;
        }*/
	
	
   /* void OnTriggerEnter2D(Collider2D other)
    {
        //other.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
       // other.GetComponent<Rigidbody2D>().AddForce(Vector3.up*bounceFactor, ForceMode2D.Impulse);


        if (!hasSpawned)
        {
            spawner.SendMessage("Spawn");
            hasSpawned = true;
        }

        Invoke("DieCloud", 15f);

    } */
    
    void DieCloud()
    {
        if (tag == "Cloud")
        Destroy(gameObject);
    }
}
