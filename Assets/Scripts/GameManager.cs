using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    static GameManager _instanse;
    //싱글턴 패턴
    //한 번에 2개 이상 생기지 않도록 한정시키는(제한시키는) 패턴

    public static GameManager instanse
    {
        //프로퍼티
        get
        {
            _instanse = FindObjectOfType<GameManager>();        //게임 매니저가 있는지 확인

            if (_instanse == null)      //_instanse가 없다면
            {
                GameObject go = new GameObject("GameManager");      //게임 매니저 오브젝트 추가
                _instanse = go.AddComponent<GameManager>();         //게임 매니저 컴포넌트 추가
            }

            return _instanse;       //반환
        }
    }

    void Start()
    {
        if(instanse == null) 
        {
            _instanse = this;
        }
        //중복된 게임 매니저가 존재하는 경우
        else
        {
            GameObject.Destroy(gameObject);
        }
    }

    public void GameOver()
    {
        Debug.Log("게임 오버");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
