using UnityEngine;
using UnityEngine.UI;       // Unity-UI를 사용하기 위해 선언한 네임스페이스
using UnityEngine.Events;   // UnityEvent 관련 API를 사용하기 위해 선언한 네임스페이스
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    // 버튼을 연결할 변수
    public Button startButton;
    public Button restartButton;
    public Button quitButton;

    private UnityAction action;

    void Start()
    {
        // UnityAction을 사용한 이벤트 연결 방식
        action = () => OnStartClick();
        startButton.onClick.AddListener(action);

    
    }

    public void OnButtonClick(string msg)
    {
        Debug.Log($"Click Button : {msg}");
    }
    public void OnClickRestart()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene (gameObject.scene.name);
    }

    public void OnStartClick()
    {
        SceneManager.LoadScene("Level_01");
        SceneManager.LoadScene("Play", LoadSceneMode.Additive);
    }

    public void GameExit()
{
    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
    #else
        Application.Quit();
    #endif
}
 
    

}

