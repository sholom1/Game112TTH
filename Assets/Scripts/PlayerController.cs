using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<Zombie>(out Zombie zombie))
        {
            GameManager.Instance.UpdateScore(2);
            Destroy(zombie.gameObject);
        }
    }
    //public GameObject dontDestroy;
    //// Update is called once per frame
    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.A))
    //    {
    //        Debug.Log("A has been pressed");
    //    }
    //    if (Input.GetKey(KeyCode.A))
    //    {
    //        Debug.Log("A is being held down");
    //    }
    //    if (Input.GetKeyUp(KeyCode.A))
    //    {
    //        Debug.Log("A has been released");
    //    }
    //}
    //void OnMove()
    //{
    //    DontDestroyOnLoad(dontDestroy);
    //    SceneManager.UnloadSceneAsync(1);
    //    SceneManager.LoadScene(0, LoadSceneMode.Additive);
    //}
}
