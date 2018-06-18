using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveControles : MonoBehaviour {

    public float speed = 4f;
    public float padding =1f;

    void MoverTeclado() {
        // Left
        if(Input.GetKey(KeyCode.LeftArrow)) {
            transform.position += new Vector3(-speed * Time.deltaTime, 0f, 0f);
        }
        // Right
        if(Input.GetKey(KeyCode.RightArrow)) {
            transform.position += new Vector3(speed * Time.deltaTime, 0f, 0f);
        }
        // Up
        if(Input.GetKey(KeyCode.UpArrow)) {
            transform.position += new Vector3(0f, speed * Time.deltaTime, 0f);
        }
        // Down
        if(Input.GetKey(KeyCode.DownArrow)) {
            transform.position += new Vector3(0f, -speed * Time.deltaTime, 0f);
        }

    }
    void MoverXInput() {
        // Horizontal
        float hInput = Input.GetAxis("Horizontal");
        transform.position += new Vector3(hInput * speed * Time.deltaTime, 0f);
        // Vertical
        float vInput = Input.GetAxis("Vertical");
        transform.position += new Vector3(0f, vInput * speed * Time.deltaTime);
    }

    // Clamping, rectificacion
    void Clamping() {
        float newX = Mathf.Clamp(transform.position.x, -10+padding, 10-padding);
        float newY = Mathf.Clamp(transform.position.y, -10+padding, 10-padding);

        transform.position = new Vector3(newX, newY, transform.position.z);
    }

    #region Metodos de Unity
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        MoverXInput();
        Clamping();
    }
    #endregion
}