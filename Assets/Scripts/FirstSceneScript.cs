using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FirstSceneScript : MonoBehaviour
{
    [Header("Animations")]
    [SerializeField] private Animator[] FirstAnims;
    [SerializeField] private Animator[] SecondAnims;

    [Space]
    [Header("Animation buttons")]
    [SerializeField] private Button BtnSecondScene;
    bool secondBool;

    [SerializeField] private Button BtnMainMenu;
    bool MainMenuBool = true;

    private void Awake()
    {
        BtnMainMenu.onClick.AddListener(LoadMainMenu);
        BtnSecondScene.onClick.AddListener(LoadSecondScene);
    }

    public void PressFirtsSprite()
    {
        Debug.Log("First");

        if (secondBool == true)
        {
            secondBool = false;
            BtnSecondScene.gameObject.SetActive(false);
            FirstAnims[0].SetBool("IsPlaying", false);
        }
        else
        {
            secondBool = true;
            BtnSecondScene.gameObject.SetActive(true);
            FirstAnims[0].SetBool("IsPlaying", true);
        }
    }
    public void PressSecondSprite()
    {
        Debug.Log("Second");
        if (MainMenuBool == true)
        {
            MainMenuBool = false;
            BtnMainMenu.gameObject.SetActive(true);
            SecondAnims[0].SetBool("IsPlaying", false);
            SecondAnims[1].SetBool("IsPlaying", false);
            SecondAnims[2].SetBool("IsPlaying", false);
            SecondAnims[3].SetBool("IsPlaying", false);
            SecondAnims[4].SetBool("IsPlaying", false);
        }
        else
        {
            MainMenuBool = true;
            BtnMainMenu.gameObject.SetActive(false);
            SecondAnims[0].SetBool("IsPlaying", true);
            SecondAnims[1].SetBool("IsPlaying", true);
            SecondAnims[2].SetBool("IsPlaying", true);
            SecondAnims[3].SetBool("IsPlaying", true);
            SecondAnims[4].SetBool("IsPlaying", true);
        }
    }

    private void LoadMainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    private void LoadSecondScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}