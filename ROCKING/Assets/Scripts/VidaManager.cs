using UnityEngine;
using UnityEngine.UI;

public class VidaManager : MonoBehaviour
{
    public Image healthBar;
    public float healthAmount = 100f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void TakeDamage(float damage)
    {
        healthAmount -= damage;
        healthBar.fillAmount = healthAmount / 100f;
    }
}
