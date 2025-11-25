using UnityEngine;

public class Personagem : MonoBehaviour
{

    [SerializeField] private int vidas = 5;
    [SerializeField] private int energia = 10;
    [SerializeField] private float velocidade = 100;

    public float getVelocidade()
    {
        return this.velocidade;
    }
    public void setvelocidade(float velocidade)
    {
        this.velocidade = velocidade;
    }

    public int getvidas()
    {
        return this.vidas;
    }

    public void setvidas(int vidas)
    {
        this.vidas = vidas;
    }

    public int getEnergia()
    {
        return this.energia;
    }

    public void SetEnergia(int energia)
    {
        
        this.energia = energia;
    }
   

}