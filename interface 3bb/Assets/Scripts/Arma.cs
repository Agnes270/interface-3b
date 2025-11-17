using UnityEngine;

public class Arma : MonoBehaviour
{
    public Transform saidaDoTiro;
    
    public GameObject bala ;

    public float intervaloDeDisparo = 0.2f;
    
    private float tempoDeDisparo = 0;

    private Camera camera;
    
    public GameObject cursor;
    
    private SpriteRenderer spriteRenderer;
    
    void Start()
    {
        camera = Camera.main;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

  
    void Update()
    {
        if (gameObject.transform.rotation.eulerAngles.z < -90 && gameObject.transform.rotation.eulerAngles.z > 90)
        {

            transform.localScale = new Vector3(1, 1, 1);
    }

        if (gameObject.transform.rotation.eulerAngles.z < -90 && gameObject.transform.rotation.eulerAngles.z > 270)

        {
          transform.localScale = new Vector3(1,-1, 1);  
            
        }      
        float CamDis = camera.transform.position.y - saidaDoTiro.position.y;
        
        Vector3 mouse = camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, CamDis));

        float AgleRad = Mathf.Atan2(y: mouse.y - transform.position.y, x: mouse.x - transform.position.x);
        float angle = (180 / Mathf.PI) * AgleRad;
        
        transform.rotation = Quaternion.AngleAxis(AgleRad, Vector3.forward);
        
        cursor.transform.position = new Vector3(mouse.x, mouse.y, transform.position.z);
       // Debug.DrawLine(mouse.x, transform.position, mouse, Color.red);
        
        if (tempoDeDisparo >= 0 && Input.GetKeyDown(KeyCode.Mouse0))
            {
                Debug.Log(tempoDeDisparo);
                GameObject b = Instantiate(this.bala, saidaDoTiro.position, saidaDoTiro.rotation) as GameObject;
                tempoDeDisparo = intervaloDeDisparo;
            }   
        
       if (tempoDeDisparo < 0)
      {   
       tempoDeDisparo -= Time.deltaTime;
      }
   
           
           
}
}