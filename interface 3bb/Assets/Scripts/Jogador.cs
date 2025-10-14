using UnityEngine;

public class Jogador : Personagem
{

    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) //Esquerda
        {
            transform.position -= new Vector3(getVelocidade() * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow)) //Direita

        {
            transform.position += new Vector3(getVelocidade() * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.UpArrow)) //Cima
        {
            transform.position += new Vector3(0, getVelocidade() * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.DownArrow)) //Baixo
        {
            transform.position -= new Vector3(0, getVelocidade() * Time.deltaTime, 0);
        }

    }

    private void OnCollisionEnter2D (Collision2D other)
    {
        if (other.gameObject.tag == "Inimigo")
        {
            int vidas = getvidas() - 1;
            setvidas(vidas);
        } 
            
            
    }
            
}    
