using UnityEngine;

public class EnemyHp : MonoBehaviour
{
    public float maxHP = 100f;
    public float currHP;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currHP = maxHP;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void TookDmg(float dmg)
    {
        currHP -= dmg;
        if (currHP <= 0)
        {
            Debug.Log("Enemy Died");
            Destroy(gameObject);
        }
    }
}
