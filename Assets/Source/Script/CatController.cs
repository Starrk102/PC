using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour, IMood
{
    [SerializeField]
    private UniversalScriptableObject CatScriptableObject;
    [Range(0, 2f)] private float mood;
    private Animator animator;
    private string text;

    private void Start()
    {
        mood = CatScriptableObject.Mood;
        animator = GetComponent<Animator>();
        if(mood == 0)
        {
            animator.Play("Idle_1");
            text = "Ваша кошка грустит";
        }
        else if(mood == 1)
        {
            animator.Play("Idle_2");
            text = "Вашей кошке хорошо";
        }        
        else if(mood == 2)
        {
            animator.Play("Idle_3");
            text = "Ваша кошка счастлива";
        }
    }

    public void PlayToCat()
    {
        if(mood == 0)
        {
            animator.Play("Play_1");
            var damage = 0;
            ApplayDamage(damage);
            text = "Кошка сидит на месте";
        }
        else if(mood == 1)
        {
            animator.Play("Play_2");
            var damage = 1;
            ApplayDamage(damage);
            text = "Кошка медленно бегает за мячиком";
        }
        else if(mood == 2)
        {
            animator.Play("Play_3");
            var damage = 0;
            ApplayDamage(damage);
            text = "кошка носится, как угорелая";
        }
    }

    public void PetToCat()
    {
        if (mood == 0)
        {
            animator.Play("Pet_1");
            var damage = 0;
            ApplayDamage(damage);
            text = "Кошка царапается";
        }
        else if (mood == 1)
        {
            animator.Play("Pet_2");
            var damage = 1;
            ApplayDamage(damage);
            text = "Кошка мурлычет";
        }
        else if (mood == 2)
        {
            animator.Play("Pet_3");
            var damage = 0;
            ApplayDamage(damage);
            text = "Кошка мурлычит и виляет хвостом";
        }
    }

    public void FoodToCat()
    {
        if (mood == 0)
        {
            animator.Play("Food_1");
            var damage = 1;
            ApplayDamage(damage);
            text = "Кошка все съедает, но если подойти - поцарапает";
        }
        else if (mood == 1)
        {
            animator.Play("Food_2");
            var damage = 1;
            ApplayDamage(damage);
            text = "Кошка быстро все съедает";
        }
        else if (mood == 2)
        {
            animator.Play("Food_2");
            var damage = 0;
            ApplayDamage(damage);
            text = "Кошка быстро все съедает";
        }
    }

    public void KickToCat()
    {
        if (mood == 0)
        {
            animator.Play("Kick_1");
            var damage = 0;
            ApplayDamage(damage);
            text = "Кошка прыгает и кусает за правое ухо";
        }
        else if (mood == 1)
        {
            animator.Play("Kick_2");
            var damage = -1;
            ApplayDamage(damage);
            text = "Кошка убегает на ковер и писает";
        }
        else if (mood == 2)
        {
            animator.Play("Kick_3");
            var damage = -2;
            ApplayDamage(damage);
            text = "Кошка убегает в другую комнату";
        }
    }

    public void ApplayDamage(float damage)
    {
        mood += damage;
    }

    public string GetText()
    {
        return text;
    }

    public float GetMood()
    {
        return mood;
    }
}
