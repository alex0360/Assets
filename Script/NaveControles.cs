using UnityEngine;

public class NaveControles : MonoBehaviour {

    Assets.Script.Disparos.Disparos Disparo;
    public float speed = 4f;
    public float padding =1f;
    public GameObject bullet;
    
    // Mover Con el teclado
    private void MoverTeclado() {
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
    // Mover con el GamePad
    private void MoverXInput() {
        // Horizontal
        float hInput = Input.GetAxis("Horizontal");
        transform.position += new Vector3(hInput * speed * Time.deltaTime, 0f);
        // Vertical
        float vInput = Input.GetAxis("Vertical");
        transform.position += new Vector3(0f, vInput * speed * Time.deltaTime);
    }
    // Disparo

    // Clamping, rectificacion
    private void Clamping() {
        float newX = Mathf.Clamp(transform.position.x, -10+padding, 10-padding);
        float newY = Mathf.Clamp(transform.position.y, -10+padding, 10-padding);

        transform.position = new Vector3(newX, newY, transform.position.z);
    }

    #region Metodos de Unity
    // Use this for initialization
    void Start () {
        Disparo =
        new Assets.Script.Disparos.Disparos();
    }

    // Update is called once per frame
    void Update()
    {
        Disparo.Disparo(bullet, tipo);
        MoverXInput();
        Clamping();
        
    }
    #endregion

    // Valores 
    // Valor 0{un disparo normal}
    // Valor 1{Dos disparos normales}
    public short tipo = 0;
}