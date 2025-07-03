using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    private bool _gameHasEnded;
    public GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _gameHasEnded = false;
    }


    // Update is called once per frame
    void Update()
    {

    }

    public void Endgame()
    {
        if (_gameHasEnded != true)
        {
            _gameHasEnded = true;
            Invoke("Restlevel", 2f);
        }
    }

    private void Restlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        player.SetActive(true);
    }

}
