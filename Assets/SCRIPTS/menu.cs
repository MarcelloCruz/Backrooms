using BusinessLogicLayer;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class menu : MonoBehaviour
{
    public InputField username_input;
    public InputField password_input;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void signUp()
    {
        string username;
        string password;
        username = username_input.text;
        password = password_input.text;

        if (!username.Equals("") && !password.Equals(""))
        {
            BLL.Players.signUp(username, password);
        }

    }

    public void login()
    {
       string username , password;
       username = username_input.text;
       password = password_input.text;

        DataTable query =  BLL.Players.login(username, password);
        if (query.Rows.Count > 0)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
