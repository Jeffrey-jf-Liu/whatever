using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            StartCoroutine(HurtEnemy(collision.gameObject.GetComponent<EnemyMove_Easy>()));
            
        }
    }

    public IEnumerator HurtEnemy(EnemyMove_Easy enemy)
    {
        Destroy(enemy.gameObject);
        yield return new WaitForEndOfFrame();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == ("Enemy"))
        {
            Invoke("LoadFirstScene",1f);
        }
    }
    public void LoadFirstScene()
    {
        int CurrentLevel = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(CurrentLevel);
    }
}