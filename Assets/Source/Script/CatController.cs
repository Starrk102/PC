using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour, IMood
{
    [SerializeField]
    private UniversalScriptableObject CatScriptableObject;
    [Range(0, 10f)] private float mood;

    // Start is called before the first frame update
    void Start()
    {
        mood = CatScriptableObject.Mood;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayToCat_1()
    {
        //Animator.Play();
        var damage = 0;
        ApplayDamage(damage);
    }

    public void PlayToCat_2()
    {

    }

    public void PlayToCat_3()
    {

    }

    public void ApplayDamage(float damage)
    {
        mood += damage;
    }
}
