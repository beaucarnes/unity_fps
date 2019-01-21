using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowBowScript : MonoBehaviour {

    private Rigidbody myBody;

    public float speed = 30f;

    public float deactivate_Timer = 3f;

    public float damage = 50f;

    void Awake() {
        myBody = GetComponent<Rigidbody>();
    }

    // Use this for initialization
    void Start () {
        Invoke("DeactivateGameObject", deactivate_Timer);
	}

    public void Launch(Camera mainCamera) {

        myBody.velocity = mainCamera.transform.forward * speed;

        transform.LookAt(transform.position + myBody.velocity);

    }
	
    void DeactivateGameObject() {
        if(gameObject.activeInHierarchy) {
            gameObject.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider target) {

        // after we touch an enemy deactivate game object
        if(target.tag == Tags.ENEMY_TAG) {

            target.GetComponent<HealthScript>().ApplyDamage(damage);

            gameObject.SetActive(false);

        }

    }

} // class











































