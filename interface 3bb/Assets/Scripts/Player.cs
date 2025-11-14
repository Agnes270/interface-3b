using UnityEngine;

public class Player : Personagem
{
private SpriteRenderer spriteRenderer;
private Animator animator;
private bool andando = false;
public Transform arma;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }


    void Update()
    {
        andando = false;

        if (arma.rotation.eulerAngles.z > -90 && arma.rotation.eulerAngles.z < 90)
        {
            spriteRenderer.flipX = false;
        }
        
        
        if (arma.rotation.eulerAngles.z > 90 && arma.rotation.eulerAngles.z < 270)
        {
            spriteRenderer.flipX = true;
        }
        
        if (Input.GetKey(KeyCode.LeftArrow)) 
        {
            gameObject.transform.Translate(Vector2.left * Time.deltaTime, 0);
            andando = true;
        }

        if (Input.GetKey(KeyCode.RightArrow)) 

        {
            gameObject.transform.Translate(Vector2.right * Time.deltaTime, 0);
            andando = true;
        }

        if (Input.GetKey(KeyCode.UpArrow)) 
        {
            gameObject.transform.Translate(Vector2.up * Time.deltaTime, 0);
            andando = true;
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
