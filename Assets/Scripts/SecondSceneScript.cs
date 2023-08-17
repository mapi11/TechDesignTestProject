using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SecondSceneScript : MonoBehaviour
{
    //[Space]
    [Header("Buttons")]
    [SerializeField] private Button BtnFirstScene;
    [SerializeField] private Button BtnMainMenu;

    private void Awake()
    {
        BtnFirstScene.onClick.AddListener(LoadFirstScene);
        BtnMainMenu.onClick.AddListener(LoadMainMenu);
    }

    private void LoadMainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
    private void LoadFirstScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
