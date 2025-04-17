using UnityEngine;

public class GameManager : MonoBehaviour
{
    // 현재 게임 상태 변수
    public GameState gState;

    // 게임 속도 0배속
    Time.TimeScale = 0f;

    // game over UI
    public GameObject gameOverUI;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        public enum GameState
        {
            Read,
            Restart,
            Pause,
            Quit
        }
    }

    // Update is called once per frame
    void Update()
    {
        public void OpenGameOverUi()
        {
            //옵션 창 활성화
            gameOverUi.SetActive(true);
            Debug.log("옵셩 창 활성화");
        }
        
        public void QuitGame()
        {
            //게임 종료
            Application.Quit();
            Debug.Log("게임 종료");
        }
        
    }
}
