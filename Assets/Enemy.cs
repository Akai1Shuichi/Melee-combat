using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Animator animator;
    public int maxHeath = 100;
    public int currentHeath;

    void Start()
    {
        currentHeath = maxHeath;
    }

    public void TakeDamage(int damage)
    {
        currentHeath -= damage;

        animator.SetTrigger("Hurt");

        if (currentHeath < 0)
        {
            Die();
        }
    }

    void Die()
    {
        animator.SetBool("IsDeath", true);
        // GetComponent<Collider2D>().enabled = false;
        this.enabled = false;
    }
}
