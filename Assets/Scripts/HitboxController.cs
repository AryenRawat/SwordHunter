using UnityEngine;
using System.Collections;

public class HitboxController : MonoBehaviour
{
    public Collider2D meleeHitbox;
    private float attackDuration = 1.4f;
    private float attackDmg=20f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AttackMelee()
    {
        StartCoroutine(AttackHitbox());
    }

    IEnumerator AttackHitbox()
    {
        Debug.Log("Working");
        meleeHitbox.enabled = true;
        yield return new WaitForSeconds(attackDuration);
        meleeHitbox.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Enemy"))
        {
            Debug.Log("Enemy Hurt");
            EnemyHp enemy = other.GetComponent<EnemyHp>(); 
            if (enemy != null) enemy.TookDmg(attackDmg);

            
        }
    }
    
}
