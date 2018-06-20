using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterBullerController : MonoBehaviour {

    public float speed = 1f;
    public float padding = 10.5f;
    public GameObject bullet;

    // Velocidad de el disparo
    private void BulletSpeed(float speed) {
        GetComponent<Rigidbody2D>().velocity = 
            new Vector3(0f, speed, 0f);
    }
    // Monitorizar y para destruir la el disparo
    private void Monitorizar(float padding){
        if(transform.position.y > padding)
            Destroy(gameObject);
    }

    #region Metodos de Unity
    // Use this for initialization
    void Start () {
        BulletSpeed(speed);
	}
	
	// Update is called once per frame
	void Update () {
        Monitorizar(padding);
	}
    #endregion
}
