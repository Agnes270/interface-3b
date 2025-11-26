using UnityEngine;
using UnityEngine.UI;

public class BarraDeVida: MonoBehaviour
{
    public Personagem personagem;
    
    public Slider sliderVidas;
    public Slider sliderEnergia;

    void Start()
    if (Personagem != null)
    {
        sliderVidas.minValue = 0;
        sliderVidas.maxValue = personagem.getvidas();

        sliderEnergia.minValue = 0;
        sliderEnergia.maxValue = personagem.getEnergia();
        
    }

    void Update()
    {
        sliderVidas.value = personagem.getvidas();
        sliderEnergia.value = personagem.getEnergia();
    }
       
}