using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public bool isPlaying{get;private set;}=false;
    [SerializeField] GameObject pnlPause,pnlLose,pnlWin;
    [SerializeField] TextMeshProUGUI txtScore;

[SerializeField] private AudioClip winSound,loseSound;


    private int score;

    private void Awake() {
        Instance=this;
        Time.timeScale=0;
    }
    
    public void Win(){
        isPlaying=false;
        pnlWin.SetActive(true);
        AudioManager.Instance.PlaySound(winSound);
    }

    public void StartGame(){
        isPlaying=true;
        Time.timeScale=1;
    }
    public void Lose(){
        isPlaying=false;
        pnlLose.SetActive(true);
        AudioManager.Instance.PlaySound(loseSound);
        

    }
    public void RestartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Pause(){
        Time.timeScale=0;
        isPlaying=false;
        pnlPause.SetActive(true);
    }
    public void Resume(){
        isPlaying=true;
        Time.timeScale=1;
    }
    public void ChangeScore(int score){
        this.score+=score;
        txtScore.text=$" Score: {this.score}";
    }
    
}
