using UnityEngine;

public class Attack : MonoBehaviour
{
    public Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            meleeAttack();

        }

    }

    public void meleeAttack()
    {
        animator.SetTrigger("isAttack");
    }
}
