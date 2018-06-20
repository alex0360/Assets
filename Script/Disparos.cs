using System;
using UnityEngine;

namespace Assets.Script.Disparos
{
    public class Disparos : MonoBehaviour {

        public void Disparo(GameObject bullet, short Tipo=0, float pUpMas=1.75f, float pDobleMas= 0.65f) {
            
            if(Tipo == 0)
                Disparo(bullet,1.75f);
            if(Tipo== 1)
                Disparo(bullet,1.5f,pDobleMas);

        }

        private void Disparo(GameObject bullet, float UpMas) {
            // tecla Space
            if(Input.GetKeyDown(KeyCode.Space)) {
                // Posicion de la nave
                GameObject fighter = GameObject.Find("fighter");
                if(fighter != null) {
                    Vector3 newCenterPosition = fighter.transform.position + Vector3.up * UpMas;
                    Instantiate(bullet, newCenterPosition, Quaternion.identity);
                }
            }
        }
        private void Disparo(GameObject bullet,float UpMas,float DobleMas)
        {
            // tecla Space
            if(Input.GetKeyDown(KeyCode.Space)) {
                // Posicion de la nave
                GameObject fighter = GameObject.Find("fighter");
                if(fighter != null) {
                    Vector3 newLeftPosition = fighter.transform.position + Vector3.up * UpMas+ Vector3.left * DobleMas;
                    Vector3 newRightPosition = fighter.transform.position + Vector3.up * UpMas+ Vector3.right * DobleMas;
                    // Invocando las balas
                    Instantiate(bullet, newLeftPosition, Quaternion.identity);
                    Instantiate(bullet, newRightPosition, Quaternion.identity);
                }
            }
        }
    }
}
