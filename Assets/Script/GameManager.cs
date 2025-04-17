using UnityEngine;

public class GameManager : MonoBehaviour
{
    // ���� ���� ���� ����
    public GameState gState;

    // ���� �ӵ� 0���
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
            //�ɼ� â Ȱ��ȭ
            gameOverUi.SetActive(true);
            Debug.log("�ɼ� â Ȱ��ȭ");
        }
        
        public void QuitGame()
        {
            //���� ����
            Application.Quit();
            Debug.Log("���� ����");
        }
        
    }
}
