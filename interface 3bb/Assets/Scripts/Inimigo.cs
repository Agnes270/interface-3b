using UnityEngine;

public class Inimigo : Personagem
{
   [SerializeField] private int dano = 1;

   public float raioDeVisao = 1;
   public CircleCollider2D _visaoCollider2D;

   [SerializeField] private Transform posicaoPlayer;

   private SpriteRenderer spriteRenderer;
   private Animator animator;

   private bool andando = false;

   public void setdano(int dano)

   {
      this.dano = dano;
   }

   public int getdano()
   {
      return this.dano;

   }

   void Start()
   {
      spriteRenderer = GetComponent<SpriteRenderer>();
      animator = GetComponent<Animator>();

      if (posicaoPlayer == null)
      {
         posicaoPlayer = GameObject.FindGameObjectWithTag("Player").transform;
      }

      raioDeVisao = _visaoCollider2D.radius;
   }

   void Update()
   {
      andando = false;
      if (getvidas() > 0)
      {
         spriteRenderer.flipX = false;

      }

      if (posicaoPlayer.position.x - transform.position.x < 0)
      {
         spriteRenderer.flipX = false;
      }

      if (posicaoPlayer.position.x - transform.position.x < 0)

      {
         spriteRenderer.flipX = true;
      }

      if (posicaoPlayer != null)
      {
       if(  Vector3.Distance(posicaoPlayer.position, transform.position) <= raioDeVisao)
         {
            Debug.Log("No raio de visao: " + posicaoPlayer.position);
            transform.position = Vector3.MoveTowards(transform.position, posicaoPlayer.transform.position
               , getVelocidade() * Time.deltaTime);

            andando = true;
         }

      }
      if(getvidas() <= 0
      {
       animator.SetTrigger("Morte");  
      }
      animator.SetBool("andando", andando);
   }
      private void OnCollisionEnter2D(Collision2D collision)
      {
         if(collision.gameObject.tag == "Player" && getvidas() > 0)
      {
      if novaVida = collision.gameObject.GetComponent<Personagem>().Getvida() - getDano();
      collision.gameObject.GetComponent<Personagem>().setvidas(novaVida);

      setvidas(0);

      }
}
}
   
   