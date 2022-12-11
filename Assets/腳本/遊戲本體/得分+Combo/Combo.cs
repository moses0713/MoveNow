using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Combo : MonoBehaviour
{
    Canvas canvas;
    float nowAmount;//現在數量
    float targetAmount;//目標數量
    float t;
    [SerializeField] Image Back;
    [SerializeField] Image Front;
    [SerializeField] float fillSpeed = 0.1f;
    [SerializeField] float fillDelay = 0.5f;
    [SerializeField] bool delayFill = true;

    Coroutine bufferedFillingCoroutine;
    WaitForSeconds waitForDelayFill;

    [SerializeField] Text ComboText;//Combo顯示器
    [SerializeField] Text ScoreText;//Score顯示器

    private void Awake()
    {
        canvas = GetComponent<Canvas>();
        canvas.worldCamera = Camera.main;
        waitForDelayFill = new WaitForSeconds(fillDelay);
        ComboText.text = "x" + "0";
        ScoreText.text = "0"+" ";
    }

    public void SetCombo(int c)
    {
        ComboText.text = "x" + c;
    }

    public void SetScore(int s)
    {
        ScoreText.text = s+" ";
    }


    public void Initialize(float now,float max)
    {
        nowAmount = now / max;
        targetAmount = nowAmount;
        Back.fillAmount = nowAmount;
        Front.fillAmount = nowAmount; 
    }
    public void UpdateState(float now, float max)
    {
        targetAmount = now / max;

        if (bufferedFillingCoroutine != null)
        {
            StopCoroutine(bufferedFillingCoroutine);
        }

        if (nowAmount > targetAmount)
        {
            Front.fillAmount = targetAmount;
            bufferedFillingCoroutine = StartCoroutine(BufferedFillingCoroutine(Back));

            return;
        }

        if (nowAmount < targetAmount)
        {
            Back.fillAmount = targetAmount;
            bufferedFillingCoroutine = StartCoroutine(BufferedFillingCoroutine(Front));
        }

    }
    protected virtual IEnumerator BufferedFillingCoroutine(Image image)
    {
        if (delayFill)
        {
            yield return waitForDelayFill;
        }


        t = 0f;

        while (t < 1f)
        {
            t += Time.deltaTime * fillSpeed;
            nowAmount = Mathf.Lerp(nowAmount, targetAmount, t);
            image.fillAmount = nowAmount;

            yield return null;
        }
    }
}
