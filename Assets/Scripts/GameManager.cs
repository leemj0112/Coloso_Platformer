using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    static GameManager _instanse;
    //�̱��� ����
    //�� ���� 2�� �̻� ������ �ʵ��� ������Ű��(���ѽ�Ű��) ����

    public static GameManager instanse
    {
        //������Ƽ
        get
        {
            _instanse = FindObjectOfType<GameManager>();        //���� �Ŵ����� �ִ��� Ȯ��

            if (_instanse == null)      //_instanse�� ���ٸ�
            {
                GameObject go = new GameObject("GameManager");      //���� �Ŵ��� ������Ʈ �߰�
                _instanse = go.AddComponent<GameManager>();         //���� �Ŵ��� ������Ʈ �߰�
            }

            return _instanse;       //��ȯ
        }
    }

    void Start()
    {
        if(instanse == null) 
        {
            _instanse = this;
        }
        //�ߺ��� ���� �Ŵ����� �����ϴ� ���
        else
        {
            GameObject.Destroy(gameObject);
        }
    }

    public void GameOver()
    {
        Debug.Log("���� ����");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
