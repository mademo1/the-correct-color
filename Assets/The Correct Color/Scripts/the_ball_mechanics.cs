using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class the_ball_mechanics : MonoBehaviour
{
    public float dash_velocity;
    public int right_limit;
    public int left_limit;

    public bool red;
    public bool green;
    public bool blue;
    public float time;

    public float score;
    public TextMeshProUGUI score_text;

    public GameObject wall_destroying;
    public GameObject plus1_sound;
    public GameObject plus5_sound;
    public GameObject plus20_sound;

    // Start is called before the first frame update
    void Start()
    {
        dash_velocity = 3f;
        right_limit = 1;
        left_limit = 1;

        time = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (red == true || green == true || blue == true)
        {
            time = time - 1 * Time.deltaTime;

            if (time <= 0)
            {
                red = false;
                green = false;
                blue = false;
                time = 0.1f;
            }
        }
    }

    public void LeftButton()
    {
        if (left_limit >= 1)
        {
            transform.Translate(new Vector3(1, 0, 0) * -dash_velocity, Space.World);
            left_limit = left_limit - 1;
            right_limit = right_limit + 1;
        }
    }
    public void RightButton()
    {
        if (right_limit >= 1)
        {
            transform.Translate(new Vector3(1, 0, 0) * dash_velocity, Space.World);
            right_limit = right_limit - 1;
            left_limit = left_limit + 1;
        }
    }

    public void RedButton()
    {
        red = true;
        green = false;
        blue = false;
    }

    public void GreenButton()
    {
        red = false;
        green = true;
        blue = false;
    }

    public void BlueButton()
    {
        red = false;
        green = false;
        blue = true;
    }

    private void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "red" && red == true)
        {
            wall_destroying.GetComponent<AudioSource>().Play();
            Destroy(col.gameObject);
        }

        if (col.gameObject.tag == "green" && green == true)
        {
            wall_destroying.GetComponent<AudioSource>().Play();
            Destroy(col.gameObject);
        }

        if (col.gameObject.tag == "blue" && blue == true)
        {
            wall_destroying.GetComponent<AudioSource>().Play();
            Destroy(col.gameObject);
        }
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "red" || col.gameObject.tag == "green" || col.gameObject.tag == "blue")
        {
            SceneManager.LoadScene("game_over");
        }

        if ( col.gameObject.name == "wall")
        {
            SceneManager.LoadScene("game_over");
        }

        if (col.gameObject.tag == "+1")
        {
            plus1_sound.GetComponent<AudioSource>().Play();
            score = score + 1;
            score_text.text = "" + score;
            Destroy(col.gameObject);

            if (score >= 1f && score <= 9f)
            {
                score_text.text = "00" + score_text.text;
            }

            if (score >= 10f && score < 100f)
            {
                score_text.text = "0" + score_text.text;
            }

            if (score >= 100f && score <= 999f)
            {
                score_text.text = "" + score_text.text;
            }
        }

        if (col.gameObject.tag == "+5")
        {
            plus5_sound.GetComponent<AudioSource>().Play();
            score = score + 5;
            score_text.text = "" + score;
            Destroy(col.gameObject);

            if (score >= 1f && score <= 9f)
            {
                score_text.text = "00" + score_text.text;
            }

            if (score >= 10f && score < 100f)
            {
                score_text.text = "0" + score_text.text;
            }

            if (score >= 100f && score <= 999f)
            {
                score_text.text = "" + score_text.text;
            }
        }

        if (col.gameObject.tag == "+20")
        {
            plus20_sound.GetComponent<AudioSource>().Play();
            score = score + 20;
            score_text.text = "" + score;
            Destroy(col.gameObject);

            if (score >= 1f && score <= 9f)
            {
                score_text.text = "00" + score_text.text;
            }

            if (score >= 10f && score < 100f)
            {
                score_text.text = "0" + score_text.text;
            }

            if (score >= 100f && score <= 999f)
            {
                score_text.text = "" + score_text.text;
            }
        }
    }
}
