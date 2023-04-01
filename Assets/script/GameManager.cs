using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class GameManager : MonoBehaviour
{

    public Question[] question;
    private static List<Question> unansweredQuestions;
    private Question currentQuestion;

    // Start is called before the first frame update
    void Start()
    {
        if(unansweredQuestions == null || unansweredQuestions.Count == 0)
        {
            unansweredQuestions = question.ToList<Question>();

        }
        GetRandomQuestion();
        Debug.Log(currentQuestion.fact  + currentQuestion.isPuluh);
    }

    
    void GetRandomQuestion()
    {
        int randomQuestionIndex = Random.Range(0, unansweredQuestions.Count);
        currentQuestion = unansweredQuestions[randomQuestionIndex];

        unansweredQuestions.RemoveAt(randomQuestionIndex);
    }
}
